using FastOrder.Domain.Data.Repositories.Abstractions;
using FastOrder.Domain.Models;
using FastOrder.Domain.Services.Abstractions;

namespace FastOrder.Domain.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _itemRepository.GetAllAsync();
        }

        public async Task<Item?> GetByIdAsync(int id)
        {
            return await _itemRepository.GetByIdAsync(id);
        }

        public async Task<Item> CreateAsync(Item item)
        {
            // **Regra de Negócio:** Preço deve ser positivo
            if (item.Price <= 0)
            {
                throw new ArgumentException("Product price must be greater than zero.");
            }

            await _itemRepository.AddAsync(item);
            await _itemRepository.SaveChangesAsync(); // Commit (salvar no DB)

            return item;
        }

        public async Task<bool> UpdateAsync(Item item)
        {
            var existingItem = await _itemRepository.GetByIdAsync(item.Id);
            if (existingItem == null)
            {
                return false; // Produto não encontrado
            }

            // **Regra de Negócio:** Se o estoque for zerado, o produto é desativado
            if (item.StockQuantity < 0)
            {
                item.StockQuantity = 0;
            }

            // O EF Core irá rastrear e atualizar as propriedades alteradas
            _itemRepository.Update(item);

            // Verifica se alguma linha foi afetada
            return await _itemRepository.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var itemToDelete = await _itemRepository.GetByIdAsync(id);
            if (itemToDelete == null)
            {
                return false; // Produto não encontrado
            }

            _itemRepository.Remove(itemToDelete);

            // Verifica se alguma linha foi afetada
            return await _itemRepository.SaveChangesAsync() > 0;
        }
    }
}

using FastOrder.Domain.Data.Repositories.Abstractions;
using FastOrder.Domain.Models;

namespace FastOrder.Domain.Data.Repositories
{
    //usando o generctRepository como herança e tendo acesso a todos os metodos

    public class ItemRepository : GenericRepository<Item, int>, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {
        }

        // Exemplo de implementação de método específico
        /*
        public async Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold)
        {
            return await _dbSet
                .AsNoTracking()
                .Where(p => p.StockQuantity < threshold)
                .ToListAsync();
        }
        */
    }
}

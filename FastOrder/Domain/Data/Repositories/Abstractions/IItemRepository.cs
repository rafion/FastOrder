using FastOrder.Domain.Models;

namespace FastOrder.Domain.Data.Repositories.Abstractions
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        // Adicionar métodos específicos do Product aqui, se necessário.
        // Ex: Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
    }
}

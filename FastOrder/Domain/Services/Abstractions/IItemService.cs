using FastOrder.Domain.Models;

namespace FastOrder.Domain.Services.Abstractions
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAllAsync();
        Task<Item?> GetByIdAsync(Guid id);
        Task<Item> CreateAsync(Item item);
        Task<bool> UpdateAsync(Item item);
        Task<bool> DeleteAsync(Guid id);


    }
}

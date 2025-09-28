using FastOrder.Domain.Models;

namespace FastOrder.Domain.Data.Repositories.Abstractions
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}

using System.Linq.Expressions;

namespace FastOrder.Domain.Data.Repositories.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        // Consultas
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        // Comandos
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);

        // Salva as mudanças pendentes (Unit of Work)
        Task<int> SaveChangesAsync();
    }

}

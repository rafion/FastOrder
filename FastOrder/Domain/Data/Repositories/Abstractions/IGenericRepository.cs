using System.Linq.Expressions;

namespace FastOrder.Domain.Data.Repositories.Abstractions
{
    public interface IGenericRepository<TEntity, Tkey> where TEntity : class
    {
        // Consultas
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Tkey id);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        // Comandos
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        // Salva as mudanças pendentes, commit no context da requisição,  (Unit of Work)
        Task<int> SaveChangesAsync();
    }

}

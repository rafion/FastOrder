using FastOrder.Domain.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FastOrder.Domain.Data.Repositories
{

        public class GenericRepository<T> : IGenericRepository<T> where T : class
        {
            protected readonly AppDbContext _context;
            protected readonly DbSet<T> _dbSet;

            public GenericRepository(AppDbContext context)
            {
                _context = context;
                _dbSet = context.Set<T>();
            }

            public async Task<IEnumerable<T>> GetAllAsync()
            {
                // AsNoTracking é bom para consultas somente leitura, melhora a performance
                return await _dbSet.AsNoTracking().ToListAsync();
            }

            public async Task<T?> GetByIdAsync(int id)
            {
                // FindAsync é o método mais rápido para buscar por chave primária
                return await _dbSet.FindAsync(id);
            }

            public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
            {
                return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
            }

            public async Task AddAsync(T entity)
            {
                await _dbSet.AddAsync(entity);
            }

            public void Update(T entity)
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }

            public void Remove(T entity)
            {
                _dbSet.Remove(entity);
            }

            public async Task<int> SaveChangesAsync()
            {
                return await _context.SaveChangesAsync();
            }
        }
    
}

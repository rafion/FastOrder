using FastOrder.Domain.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FastOrder.Domain.Data.Repositories
{

        public class GenericRepository<TEntity, Tkey> : IGenericRepository<TEntity, Tkey>  where TEntity : class
      
    {
            protected readonly AppDbContext _context;
            protected readonly DbSet<TEntity> _dbSet;

            public GenericRepository(AppDbContext context)
            {
                _context = context;
                _dbSet = context.Set<TEntity>();
            }

            public async Task<IEnumerable<TEntity>> GetAllAsync()
            {
                // AsNoTracking é bom para consultas somente leitura, melhora a performance
                return await _dbSet.AsNoTracking().ToListAsync();
            }

            public async Task<TEntity?> GetByIdAsync(Tkey id)
            {
                // FindAsync é o método mais rápido para buscar por chave primária
                return await _dbSet.FindAsync(id);
            }

            public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
            {
                return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
            }

            public async Task AddAsync(TEntity entity)
            {
                await _dbSet.AddAsync(entity);
            }

            public void Update(TEntity entity)
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }

            public void Remove(TEntity entity)
            {
                _dbSet.Remove(entity);
            }

            public async Task<int> SaveChangesAsync()
            {
                return await _context.SaveChangesAsync();
            }
        }
    
}

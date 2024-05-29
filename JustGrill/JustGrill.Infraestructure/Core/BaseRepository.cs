using JustGrill.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;
        private DbSet<TEntity> _entities;

        protected BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entities =this._dbContext.Set<TEntity>();
        }

        public async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.AnyAsync(filter);
        }

        public async Task<TEntity> Get(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public async Task Save(TEntity entity)
        {
            _entities.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Save(List<TEntity> entityList)
        {
            _entities.AddRange(entityList);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _entities.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(List<TEntity> entityList)
        {
            _entities.UpdateRange(entityList);
            await _dbContext.SaveChangesAsync();
        }
    }
}

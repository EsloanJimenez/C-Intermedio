using System.Linq.Expressions;

namespace JustGrill.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Save(TEntity entity);
        Task Save(List<TEntity> entityList);
        Task Update(TEntity entity);
        Task Update(List<TEntity> entityList);
        Task<TEntity> Get(int Id);
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}

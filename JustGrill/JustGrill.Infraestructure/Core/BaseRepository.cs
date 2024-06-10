using JustGrill.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using JustGrill.Domain.Core;

namespace JustGrill.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context;
        private DbSet<TEntity> _entities;

        protected BaseRepository(DbContext context)
        {
            this.context = context;
            this._entities = this.context.Set<TEntity>();
        }

        public async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.AnyAsync(filter);
        }

        public virtual async Task<TEntity> Get(int Id) {
            return await _entities.FindAsync(Id);
        }

        public virtual async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public virtual async Task Save(TEntity entity)
        {
            _entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task Save(List<TEntity> entityList)
        {
            _entities.AddRange(entityList);
            await context.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            _entities.Update(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task Update(List<TEntity> entityList)
        {
            _entities.UpdateRange(entityList);
            await context.SaveChangesAsync();
        }
    }
}


/*
 * 
 * 
  INSERT INTO DetalleFacturas (DetalleID, FacturaID, MenuID, Cantidad, Precio)


  INSERT INTO Pedidos (PedidoID, ClienteID, MesaID, FechaPedido, Total)
  VALUES
  (1, 1, 1, '2024-06-05', 1873.74);
*/
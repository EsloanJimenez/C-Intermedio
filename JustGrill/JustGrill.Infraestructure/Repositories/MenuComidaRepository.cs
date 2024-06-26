using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Core;
using JustGrill.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories
{
    public class MenuComidaRepository : BaseRepository<MenuComida>, IMenuComida
    {
        private readonly JustGrillContext _context;
        public MenuComidaRepository(JustGrillContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public List<MenuComidaModel> GetMenuComida()
        {
            var menuComida = _context.MenuComida.Select(cd => new MenuComidaModel()
            {
                MenuID = cd.MenuID,
                Nombre = cd.Nombre,
                Precio = cd.Precio
            }).ToList();

            return menuComida;
        }

        public override async Task Save(MenuComida entity)
        {
            if (entity is null)
                throw new ArgumentNullException("La entidad MenuComida no puede ser nulo");

            await base.Save(entity);
        }
        public override Task Save(List<MenuComida> entities)
        {
            if (entities is null)
                throw new ArgumentNullException("La entidad MenuComida no puede ser nulo.");

            if (!entities.Any())
                throw new MenuComidaException("Debe proporcionar por lo menos un articulo.");

            return base.Save(entities);
        }
        public override Task Update(MenuComida entity)
        {
            if (entity is null)
                throw new ArgumentNullException("La entidad MenuComida no puede ser nulo");

            return base.Update(entity);
        }
        public override Task Update(List<MenuComida> entities)
        {
            if (entities is null)
                throw new ArgumentNullException("La entidad MenuComida no puede ser nulo.");

            if (!entities.Any())
                throw new MenuComidaException("Debe proporcionar por lo menos un articulo.");

            return base.Update(entities);
        }
        public override Task<List<MenuComida>> GetAll(Expression<Func<MenuComida, bool>> filter) => base.GetAll(filter);
        public override Task<MenuComida> Get(int Id) => base.Get(Id);
    }
}

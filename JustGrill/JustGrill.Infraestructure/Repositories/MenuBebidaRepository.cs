using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Core;
using JustGrill.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories
{
    public class MenuBebidaRepository : BaseRepository<MenuBebida>, IMenuBebida
    {
        private readonly JustGrillContext _context;
        public MenuBebidaRepository(JustGrillContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public List<MenuBebidaModel> GetMenuBebida()
        {
            var menuBebida = _context.MenuBebida.Select(cd => new MenuBebidaModel()
            {
                MenuID = cd.MenuID,
                Nombre = cd.Nombre,
                Precio = cd.Precio
            }).ToList();

            return menuBebida;
        }

        public override async Task Save(MenuBebida entity)
        {
            if (entity is null)
                throw new ArgumentNullException("La entidad MenuBebida no puede ser nulo");

            await base.Save(entity);
        }
        public override Task Save(List<MenuBebida> entities)
        {
            if (entities is null)
                throw new ArgumentNullException("La entidad MenuBebida no puede ser nulo.");

            if (!entities.Any())
                throw new MenuBebidaException("Debe proporcionar por lo menos un articulo.");

            return base.Save(entities);
        }
        public override Task Update(MenuBebida entity)
        {
            if (entity is null)
                throw new ArgumentNullException("La entidad MenuBebida no puede ser nulo");

            return base.Update(entity);
        }
        public override Task Update(List<MenuBebida> entities)
        {
            if (entities is null)
                throw new ArgumentNullException("La entidad MenuBebida no puede ser nulo.");

            if (!entities.Any())
                throw new MenuBebidaException("Debe proporcionar por lo menos un articulo.");

            return base.Update(entities);
        }
        public override Task<List<MenuBebida>> GetAll(Expression<Func<MenuBebida, bool>> filter) => base.GetAll(filter);
        public override Task<MenuBebida> Get(int Id) => base.Get(Id);
    }
}

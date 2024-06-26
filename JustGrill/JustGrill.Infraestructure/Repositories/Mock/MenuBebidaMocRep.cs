using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories.Mock
{
    public class MenuBebidaMocRep : IMenuBebida
    {
        private List<MenuBebida> menuBebidas;
        public MenuBebidaMocRep()
        {
            this.menuBebidas = new List<MenuBebida>();
        }
        public Task<bool> Exists(Expression<Func<MenuBebida, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<MenuBebida> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuBebida>> GetAll(Expression<Func<MenuBebida, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<MenuBebidaModel> GetMenuBebida()
        {
            throw new NotImplementedException();
        }

        public Task Save(MenuBebida entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<MenuBebida> entityList)
        {
            throw new NotImplementedException();
        }

        public Task Update(MenuBebida entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<MenuBebida> entityList)
        {
            throw new NotImplementedException();
        }
    }
}

using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories.Mock
{
    public class MenuComidaMocRep : IMenuComida
    {
        private List<MenuComida> menuComidas;
        public MenuComidaMocRep()
        {
            this.menuComidas = new List<MenuComida>();
        }
        public Task<bool> Exists(Expression<Func<MenuComida, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<MenuComida> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MenuComida>> GetAll(Expression<Func<MenuComida, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<MenuComidaModel> GetMenuComida()
        {
            throw new NotImplementedException();
        }

        public Task Save(MenuComida entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<MenuComida> entityList)
        {
            throw new NotImplementedException();
        }

        public Task Update(MenuComida entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<MenuComida> entityList)
        {
            throw new NotImplementedException();
        }
    }
}

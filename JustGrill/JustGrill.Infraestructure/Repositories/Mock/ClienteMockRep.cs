using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories.Mock
{
    public class ClienteMockRep : ICliente
    {
        private List<Cliente> cliente;
        public ClienteMockRep()
        {
            this.cliente = new List<Cliente>();
        }
        public Task<bool> Exists(Expression<Func<Cliente, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> GetAll(Expression<Func<Cliente, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> GetCliente()
        {
            throw new NotImplementedException();
        }

        public Task Save(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Cliente> entityList)
        {
            throw new NotImplementedException();
        }

        public Task Update(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Cliente> entityList)
        {
            throw new NotImplementedException();
        }
    }
}

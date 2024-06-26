using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Core;
using JustGrill.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, ICliente
    {
        private readonly JustGrillContext _context;
        public ClienteRepository(JustGrillContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public List<ClienteModel> GetCliente()
        {
            var clientes = _context.Cliente.Select(cd => new ClienteModel()
            {
                ClienteID = cd.ClienteID,
                Nombre = cd.Nombre,
                Telefono = cd.Telefono,
                Email = cd.Email
            }).ToList();

            return clientes;
        }

        public override async Task Save(Cliente entity)
        {
            if (entity is null)
                throw new ArgumentNullException("La entidad Cliente no puede ser nulo");

            await base.Save(entity);
        }
        public override Task Save(List<Cliente> entities)
        {
            if (entities is null)
                throw new ArgumentNullException("La entidad Cliente no puede ser nulo.");

            if (!entities.Any())
                throw new ClienteException("Debe proporcionar por lo menos un Cliente.");

            return base.Save(entities);
        }
        public override Task Update(Cliente entity)
        {
            if (entity is null)
                throw new ArgumentNullException("La entidad Cliente no puede ser nulo");

            return base.Update(entity);
        }
        public override Task Update(List<Cliente> entities)
        {
            if (entities is null)
                throw new ArgumentNullException("La entidad Cliente no puede ser nulo.");

            if (!entities.Any())
                throw new ClienteException("Debe proporcionar por lo menos un Cliente.");

            return base.Update(entities);
        }
        public override Task<List<Cliente>> GetAll(Expression<Func<Cliente, bool>> filter) => base.GetAll(filter);
        public override Task<Cliente> Get(int Id) => base.Get(Id);
    }
}

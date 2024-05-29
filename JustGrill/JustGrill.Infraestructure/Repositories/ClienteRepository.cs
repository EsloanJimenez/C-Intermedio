using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Core;

namespace JustGrill.Infraestructure.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, ICliente
    {
        private readonly JustGrillContext _context;
        public ClienteRepository(JustGrillContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}

using JustGrill.Domain.Entities;
using JustGrill.Domain.Models;

namespace JustGrill.Domain.Interfaces
{
    public interface ICliente : IBaseRepository<Cliente>
    {
        List<ClienteModel> GetCliente();
    }
}

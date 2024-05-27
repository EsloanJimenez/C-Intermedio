using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface ICliente
    {
        Task Save(Cliente cliente);
        Task Save(List<Cliente> clienteList);
        Task Update(Cliente cliente);
        Task Update(List<Cliente> clienteList);
        Task Get(int idCliente);
        Task<List<Cliente>> GetAll();
    }
}

using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface IMesa
    {
        Task Save(Mesa mesa);
        Task Save(List<Mesa> mesaList);
        Task Update(Mesa mesa);
        Task Update(List<Mesa> mesaList);
        Task Get(int idMesa);
        Task<List<Mesa>> GetAll();
    }
}

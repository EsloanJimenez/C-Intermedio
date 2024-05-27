using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface IFactura
    {
        Task Save(IFactura factura);
        Task Save(List<IFactura> facturaList);
        Task Update(IFactura factura);
        Task Update(List<IFactura> facturaList);
        Task Get(int idFactura);
        Task<List<IFactura>> GetAll();
    }
}

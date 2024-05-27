using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface IPedido
    {
        Task Save(Pedido pedido);
        Task Save(List<Pedido> pedidoList);
        Task Update(Pedido pedido);
        Task Update(List<Pedido> pedidoList);
        Task Get(int idPedido);
        Task<List<Pedido>> GetAll();
    }
}

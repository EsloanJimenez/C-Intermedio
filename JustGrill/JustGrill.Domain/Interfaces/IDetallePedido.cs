using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface IDetallePedido
    {
        Task Save(DetallePedido detallePedido);
        Task Save(List<DetallePedido> detallePedidoList);
        Task Update(DetallePedido detallePedido);
        Task Update(List<DetallePedido> detallePedidoList);
        Task Get(int idDetallePedido);
        Task<List<DetallePedido>> GetAll();
    }
}

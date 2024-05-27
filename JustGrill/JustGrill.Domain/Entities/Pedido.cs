using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Pedido : AuditoriaEntities
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdMesa { get; set; }
    }
}

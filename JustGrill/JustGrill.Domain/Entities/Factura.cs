using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Factura : AuditoriaEntities
    {
        public int IdFactura { get; set; }
        public int IdPedido { get; set; }
    }
}

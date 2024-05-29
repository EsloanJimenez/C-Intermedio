using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Pedido : AuditoriaEntities
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public int CamareroID { get; set; }
        public int MesaID { get; set; }
    }
}

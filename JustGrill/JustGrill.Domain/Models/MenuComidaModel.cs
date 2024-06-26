using JustGrill.Domain.Core;

namespace JustGrill.Domain.Models
{
    public class MenuComidaModel
    {
        public int MenuID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
    }
}

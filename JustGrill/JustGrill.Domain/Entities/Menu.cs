using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Menu : EntidadConNombre
    {
        public int IdPlato { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public string? Categoria { get; set; }
    }
}

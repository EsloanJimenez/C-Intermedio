using System.ComponentModel.DataAnnotations;

namespace JustGrill.Domain.Core
{
    public class Menu : EntidadConNombre
    {
        [Key]
        public int MenuID { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public bool Estado { get; set; }
    }
}

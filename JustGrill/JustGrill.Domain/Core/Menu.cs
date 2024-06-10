namespace JustGrill.Domain.Core
{
    public class Menu : EntidadConNombre
    {
        public int MenuID { get; set; }
        public decimal Precio { get; set; }
        public required string Categoria { get; set; }
        public bool Estado { get; set; }
    }
}

namespace JustGrill.Domain.Models
{
    public class EmpleadoModel
    {
        public int EmpleadoID { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Cargo { get; set; }
    }
}

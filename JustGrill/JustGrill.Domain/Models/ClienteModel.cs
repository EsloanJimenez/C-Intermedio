namespace JustGrill.Domain.Models
{
    public class ClienteModel
    {
        public int ClienteID { get; set; }
        public required string Nombre { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
    }
}

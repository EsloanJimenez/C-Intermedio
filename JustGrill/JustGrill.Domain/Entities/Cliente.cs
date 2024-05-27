using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Cliente : EntidadConNombre
    {
        public int IdCliente { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}

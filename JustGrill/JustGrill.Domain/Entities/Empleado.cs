using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Empleado : Persona
    {
        public int EmpleadoID { get; set; }
        public required string Apellido { get; set; }
        public required string Cargo { get; set; }
        public int Password { get; set; }
    }
}

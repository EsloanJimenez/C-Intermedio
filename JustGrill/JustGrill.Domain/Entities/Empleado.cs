using JustGrill.Domain.Core;

namespace JustGrill.Domain.Entities
{
    public class Empleado : EntidadConNombre
    {
        public int IdEmpleado {  get; set; }
        public string? Cargo { get; set; }
    }
}

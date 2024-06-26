using JustGrill.Domain.Entities;
using JustGrill.Domain.Models;

namespace JustGrill.Domain.Interfaces
{
    public interface IEmpleado : IBaseRepository<Empleado>
    {
        List<EmpleadoModel> GetEmpleados();
    }
}

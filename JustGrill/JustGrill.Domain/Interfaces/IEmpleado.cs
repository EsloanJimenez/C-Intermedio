using JustGrill.Domain.Entities;

namespace JustGrill.Domain.Interfaces
{
    public interface IEmpleado
    {
        Task Save(Empleado empleado);
        Task Save(List<Empleado> empleadoList);
        Task Update(Empleado empleado);
        Task Update(List<Empleado> empleadoList);
        Task Get(int idEmpleado);
        Task<List<Empleado>> GetAll();
    }
}

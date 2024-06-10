using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories.Mock
{
    public class EmpleadoMockRep : IEmpleado
    {
        private List<Empleado> empleados;

        public EmpleadoMockRep()
        {
            this.empleados = new List<Empleado>();
        }
        public Task<bool> Exists(Expression<Func<Empleado, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empleado>> GetAll(Expression<Func<Empleado, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<EmpleadoModel> GetEmpleados()
        {
            throw new NotImplementedException();
        }

        public Task Save(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Empleado> entityList)
        {
            throw new NotImplementedException();
        }

        public Task Update(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Empleado> entityList)
        {
            throw new NotImplementedException();
        }
    }
}

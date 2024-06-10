using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Core;
using JustGrill.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace JustGrill.Infraestructure.Repositories
{
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleado
    {
        private readonly JustGrillContext _context;
        public EmpleadoRepository(JustGrillContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        /*
        public List<EmpleadoModel> GetEmpleados()
        {
            var empleado = (from em in _context.Empleado
                           where em.Deleted == false
                           select new EmpleadoModel() {
                               EmpleadoID = em.EmpleadoID,
                               Nombre = em.Nombre,
                               Apellido = em.Apellido,
                               Cargo = em.Cargo
                           }).ToList();

            return empleado;
        }*/
        public List<EmpleadoModel> GetEmpleados()
        {
            var empleados = _context.Empleado.Select(cd => new EmpleadoModel()
            {
                EmpleadoID = cd.EmpleadoID,
                Nombre = cd.Nombre,
                Apellido = cd.Apellido,
                Cargo = cd.Cargo
            }).ToList();

            return empleados;
        }

        public override Task Save(Empleado entity)
        {
            if (entity is null) throw new ArgumentNullException("La entidad empleado no puede ser nulo");

            return base.Save(entity);
        }
        public override Task Save(List<Empleado> entities)
        {
            if (entities is null) throw new ArgumentNullException("La entidad empleado no puede ser nulo.");

            if (!entities.Any()) throw new EmpleadoException("Debe proporcionar por lo menos un empleado.");

            return base.Save(entities);
        }
        public override Task Update(Empleado entity)
        {
            if (entity is null) throw new ArgumentNullException("La entidad empleado no puede ser nulo");

            return base.Update(entity);
        }
        public override Task Update(List<Empleado> entities)
        {
            if (entities is null) throw new ArgumentNullException("La entidad empleado no puede ser nulo.");

            if (!entities.Any()) throw new EmpleadoException("Debe proporcionar por lo menos un empleado.");

            return base.Update(entities);
        }
        public override Task<List<Empleado>> GetAll(Expression<Func<Empleado, bool>> filter) => base.GetAll(filter);
        public override Task<Empleado> Get(int Id) => base.Get(Id);
        /*
        public List<EmpleadoModel> GetEmpleadosById(int empleadoId)
        {
            var empleado = (from em in _context.Empleado
                            where em.Deleted == false
                            && em.EmpleadoID == empleadoId
                            select new EmpleadoModel()
                            {
                                EmpleadoID = em.EmpleadoID,
                                Nombre = em.Nombre,
                                Apellido = em.Apellido,
                                Cargo = em.Cargo
                            }).ToList();

            return empleado;
        }*/
    }
}
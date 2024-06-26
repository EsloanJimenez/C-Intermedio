using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace JustGrill.Infraestructure.Text
{
    public class EmpleadoRepositoryTest
    {
        private JustGrillContext context = null;
        private IEmpleado empleadoRepository;
        public EmpleadoRepositoryTest()
        {
            var op = new DbContextOptionsBuilder<JustGrillContext>()
                .UseInMemoryDatabase("JustGrill")
                .Options;

            context = new JustGrillContext(op);

            empleadoRepository = new EmpleadoRepository(context);

            List<Empleado> empleados = new List<Empleado>() {
                new Empleado()
                {
                    Nombre = "Esloan",
                    Apellido = "Jimenez",
                    Cargo = "Gerente",
                    Password = 1234,
                    StartDate = DateTime.Now,
                    CreationDate = DateTime.Now
                },
                new Empleado()
                {
                    Nombre = "Yhennifer",
                    Apellido = "Abreu",
                    Cargo = "Supervisora",
                    Password = 5678,
                    StartDate = DateTime.Now,
                    CreationDate = DateTime.Now
                }

            };

            this.empleadoRepository.Save(empleados);
        }
        [Fact]
        public void GetEmpleados_WithValiudEmpleadoModel()
        {
            // Arrange
            var empleados = this.empleadoRepository.GetEmpleados();

            // Expect
            var empleadoName = "Esloan";

            // Assert
            Assert.NotNull(empleados);
            Assert.IsType<List<EmpleadoModel>>(empleados);
            Assert.True(empleados.Any());
            Assert.Equal(empleadoName, empleados[0].Nombre);

        }
    }
}
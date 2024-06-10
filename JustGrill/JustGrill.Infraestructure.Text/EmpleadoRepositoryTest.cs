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
        }
        [Fact]
        public void GetEmpleados_WithValiudEmpleadoModel()
        {
            // Arrange
            var empleados = this.empleadoRepository.GetEmpleados();
            
            // Expect
            // Assert
            Assert.NotNull(empleados);
            Assert.IsType<List<EmpleadoModel>>(empleados);

        }
    }
}
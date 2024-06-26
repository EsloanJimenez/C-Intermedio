using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace JustGrill.Infraestructure.Text
{
    public class ClienteRepositoryTest
    {
        private JustGrillContext context = null;
        private ICliente clienteRepository;
        public ClienteRepositoryTest()
        {
            var op = new DbContextOptionsBuilder<JustGrillContext>()
                .UseInMemoryDatabase("JustGrill")
                .Options;

            context = new JustGrillContext(op);

            clienteRepository = new ClienteRepository(context);

            List<Cliente> cliente = new List<Cliente>() {
                new Cliente()
                {
                    Nombre = "Esloan",
                    Telefono = "8095904682",
                    Email = "EsloanJimenez@gmail.com"
                },
                new Cliente()
                {
                    Nombre = "Yhennifer",
                    Telefono = "8095904682",
                    Email = "EsloanJimenez@gmail.com"
                }

            };

            this.clienteRepository.Save(cliente);
        }
        [Fact]
        public void GetCliente_WithValiudClienteModel()
        {
            // Arrange
            var cliente = this.clienteRepository.GetCliente();

            // Expect
            var clienteName = "Esloan";

            // Assert
            Assert.NotNull(cliente);
            Assert.IsType<List<ClienteModel>>(cliente);
            Assert.True(cliente.Any());
            Assert.Equal(clienteName, cliente[0].Nombre);

        }
    }
}
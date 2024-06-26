using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace JustGrill.Infraestructure.Text
{
    public class MenuComidaRepositoryTest
    {
        private JustGrillContext context = null;
        private IMenuComida menuComidaRepository;
        public MenuComidaRepositoryTest()
        {
            var op = new DbContextOptionsBuilder<JustGrillContext>()
                .UseInMemoryDatabase("JustGrill")
                .Options;

            context = new JustGrillContext(op);

            menuComidaRepository = new MenuComidaRepository(context);

            List<MenuComida> menuComida = new List<MenuComida>()
            {
                new MenuComida()
                {
                    Nombre = "Churrasco",
                    Precio = 1820,
                    Categoria = "Filetes"
                },
                new MenuComida()
                {
                    Nombre = "PenneRustica",
                    Precio = 535m,
                    Categoria = "Pastas"
                }
            };

            this.menuComidaRepository.Save(menuComida);
        }
        [Fact]
        public void GetMenuComida_WithValiudMenuComidaModel()
        {
            // Arrange
            var menuComida = this.menuComidaRepository.GetMenuComida();

            // Expect
            var menuComidaName = "Churrasco";

            // Assert
            Assert.NotNull(menuComida);
            Assert.IsType<List<MenuComidaModel>>(menuComida);
            Assert.True(menuComida.Any());
            Assert.Equal(menuComidaName, menuComida[0].Nombre);

        }
    }
}
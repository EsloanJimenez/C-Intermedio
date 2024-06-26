using JustGrill.Domain.Entities;
using JustGrill.Domain.Interfaces;
using JustGrill.Domain.Models;
using JustGrill.Infraestructure.Context;
using JustGrill.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace JustGrill.Infraestructure.Text
{
    public class MenuBebidaRepositoryTest
    {
        private JustGrillContext context = null;
        private IMenuBebida menuBebidaRepository;
        public MenuBebidaRepositoryTest()
        {
            var op = new DbContextOptionsBuilder<JustGrillContext>()
                .UseInMemoryDatabase("JustGrill")
                .Options;

            context = new JustGrillContext(op);

            menuBebidaRepository = new MenuBebidaRepository(context);

            List<MenuBebida> menuBebida = new List<MenuBebida>()
            {
                new MenuBebida()
                {
                    Nombre = "Presidente",
                    Precio = 235,
                    Categoria = "Cerveza"
                },
                new MenuBebida()
                {
                    Nombre = "GoldLabel",
                    Precio = 543,
                    Categoria = "Whisky"
                },
                new MenuBebida()
                {
                    Nombre = "OldParr",
                    Precio = 385,
                    Categoria = "Whisky"
                }
            };

            this.menuBebidaRepository.Save(menuBebida);
        }
        [Fact]
        public void GetMenuBebida_WithValiudMenuBebidaModel()
        {
            // Arrange
            var menuBebida = this.menuBebidaRepository.GetMenuBebida();

            // Expect
            var menuBebidaName = "Presidente";

            // Assert
            Assert.NotNull(menuBebida);
            Assert.IsType<List<MenuBebidaModel>>(menuBebida);
            Assert.True(menuBebida.Any());
            Assert.Equal(menuBebidaName, menuBebida[0].Nombre);

        }
    }
}
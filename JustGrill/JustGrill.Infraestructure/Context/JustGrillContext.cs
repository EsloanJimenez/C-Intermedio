using JustGrill.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JustGrill.Infraestructure.Context
{
    public class JustGrillContext : DbContext
    {
        public JustGrillContext(DbContextOptions<JustGrillContext> dbContext) : base(dbContext) 
        {
                    
        }

        #region "Entities"
        /*
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleFacturas> DetalleFacturas { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        */
        public DbSet<Empleado> Empleado { get; set; }
        /*
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Guarniciones> Guarniciones { get; set; }
        public DbSet<MenuBebida> MenuBebida { get; set; }
        public DbSet<MenuComida> MenuComida { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<TerminoCoccion> TerminoCoccions { get; set; }
        */
        #endregion
    }
}

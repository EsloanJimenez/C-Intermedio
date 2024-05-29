using JustGrill.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JustGrill.Infraestructure.Context
{
    public class JustGrillContext : DbContext
    {
        public JustGrillContext(DbContextOptions<JustGrillContext> dbContext) : base(dbContext) 
        {
                    
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Camareros> Camareros { get; set;}
    }
}

using JustGrill.Domain.Interfaces;
using JustGrill.Infraestructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace JustGrill.IOC.Dependencies
{
    public static class EmpleadoDependency
    {
        public static void AddEmpleadoDependency(this IServiceCollection services)
        {
            services.AddScoped<IEmpleado, EmpleadoRepository>();

            // LA DEPENDENCIA DE LA  APP DE SERVICIOS
        }
    }
}

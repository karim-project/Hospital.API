using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.Infrustructure.Repositories;
using Hospital.Infrustructure.Repositories.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace Hospital.core
{
    public static class ModulsusCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            // Configration Mediatr
            services.AddMediatR(cfg =>cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            // Configration Mapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}

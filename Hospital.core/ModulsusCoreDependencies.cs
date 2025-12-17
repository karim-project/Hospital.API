using Hospital.Infrustructure.Repositories;
using Hospital.Infrustructure.Repositories.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Hospital.core
{
    public static class ModulsusCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}

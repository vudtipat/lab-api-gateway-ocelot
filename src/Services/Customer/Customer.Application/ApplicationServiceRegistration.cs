using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Customer.Application
{
    public static class ApplicationServiceRegistration
	{
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configulation)
        {

            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
            );

            return services;
        }
    }
}


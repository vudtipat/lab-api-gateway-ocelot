using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Order.Application
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


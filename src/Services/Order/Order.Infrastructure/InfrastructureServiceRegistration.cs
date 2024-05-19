using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Order.Infrastructure.Persistance;

namespace Order.Infrastructure
{
	public static class InfrastructureServiceRegistration
	{
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configulation)
        {
            services.AddDbContext<OrderContext>(option => option.UseSqlServer(configulation.GetConnectionString("OrderConnection")));

            return services;
        }
    }
}


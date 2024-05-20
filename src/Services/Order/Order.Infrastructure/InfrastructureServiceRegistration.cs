using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Order.Application;
using Order.Infrastructure.Persistance;
using Order.Infrastructure.Repository;

namespace Order.Infrastructure
{
	public static class InfrastructureServiceRegistration
	{
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configulation)
        {
            services.AddDbContext<OrderContext>(option => option.UseSqlServer(configulation.GetConnectionString("OrderConnection")));

            services.AddScoped<IOrderRepository,OrderRepository>();

            return services;
        }
    }
}


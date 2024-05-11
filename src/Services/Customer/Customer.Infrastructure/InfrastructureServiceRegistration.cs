using Customer.Application.IRepository;
using Customer.Infrastructure.Persistance;
using Customer.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configulation)
        {
            services.AddDbContext<CustomerContext>(option => option.UseSqlServer(configulation.GetConnectionString("CustomerConnection")));

            services.AddScoped<ICustomerRepository,CustomerRepository>();

            return services;
        }
    }
}
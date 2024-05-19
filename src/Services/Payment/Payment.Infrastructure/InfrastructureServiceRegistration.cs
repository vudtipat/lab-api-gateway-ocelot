using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Payment.Infrastructure.Persistance;

namespace Payment.Infrastructure;
public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configulation)
    {
        services.AddDbContext<PaymentContext>(option => option.UseSqlServer(configulation.GetConnectionString("PaymentConnection")));

        return services;
    }
}
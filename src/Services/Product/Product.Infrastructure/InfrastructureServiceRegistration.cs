using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Infrastructure.Persistance;

namespace Product.Infrastructure;
public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configulation)
    {
        services.AddDbContext<ProductContext>(option => option.UseSqlServer(configulation.GetConnectionString("ProductConnection")));

        return services;
    }
}
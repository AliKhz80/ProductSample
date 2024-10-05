
using Domain.Interfaces;
using Infrustructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrustructure;
public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrustructorLayer(this IServiceCollection services , IConfiguration configuration)
    {
        services
            .RegisterDBContext(configuration)
            .RegisterRepositories();


        return services;
    }

    private static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

        return services;
    }

    private static IServiceCollection RegisterDBContext(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ProductSampleDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ProductSampleDB")));

        return services;
    }

   
}

using Domain.Interfaces;
using Domain.Interfaces.BusinessIRepositories;
using Infrustructure;
using Infrustructure.BusinessRepositories;
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
        services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
        services.AddScoped(typeof(IProductAdtRepository), typeof(ProductAdtRepository));
        services.AddScoped(typeof(IProductAdtPriceRepository), typeof(ProductAdtPriceRepository));
        services.AddScoped(typeof(IProductAdtTypeRepository), typeof(ProductAdtTypeRepository));
        services.AddScoped(typeof(IProductDeliverRepository), typeof(ProductDeliverRepository));
        services.AddScoped(typeof(IProductDeliverSizeRepository), typeof(ProductDeliverSizeRepository));
        services.AddScoped(typeof(IProductJeldRepository), typeof(ProductJeldRepository));
        services.AddScoped(typeof(IProductMaterialRepository), typeof(ProductMaterialRepository));
        services.AddScoped(typeof(IProductMaterialAttributeRepository), typeof(ProductMaterialAttributeRepository));
        services.AddScoped(typeof(IProductPriceRepository), typeof(ProductPriceRepository));
        services.AddScoped(typeof(IProductPrintKindRepository), typeof(ProductPrintKindRepository));
        services.AddScoped(typeof(IProductSizeRepository), typeof(ProductSizeRepository));


        return services;
    }

    private static IServiceCollection RegisterDBContext(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ProductSampleDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ProductSampleDB")));

        return services;
    }

   
}
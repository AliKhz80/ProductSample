using Application;
using BaseSample.Middlewares;
using Infrustructure;

namespace BaseSample.Config;

public static class RegisterConfigs
{
    public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .ConfigureInfrustructorLayer(configuration)
            .ConfigureApplicationLayer()
            .RegisterMiddlewares();



        return services;
    }

    private static IServiceCollection RegisterMiddlewares(this IServiceCollection services)
    {
        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddProblemDetails();

        return services;
    }



}

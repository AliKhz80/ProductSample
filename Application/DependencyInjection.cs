﻿
using Application.Config;
using Application.Features.Product;
using Domain.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection ConfigureApplicationLayer(this IServiceCollection services)
    {
        services
            .RegisterMediatR()
            .RegisterValidator()
            .RegisterCurrentUser();


        return services;
    }

    private static IServiceCollection RegisterMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblyContaining(typeof(ProductModelMapper));
        });
        return services;
    }

    private static IServiceCollection RegisterValidator(this IServiceCollection services)
    {

        services.AddValidatorsFromAssemblyContaining(typeof(ProductModelMapper));

        return services;

    }
    private static IServiceCollection RegisterCurrentUser(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddSingleton<ICurrentUser, CurrentUser>();

        return services;
    }
}
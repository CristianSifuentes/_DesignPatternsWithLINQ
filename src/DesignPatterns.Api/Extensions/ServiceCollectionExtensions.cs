using DesignPatterns.Api.Application;
using DesignPatterns.Api.Contracts;
using DesignPatterns.Api.Infrastructure.Factories;

namespace DesignPatterns.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPatternCatalog(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        return services;
    }

    public static IServiceCollection AddPatternServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PatternPlaygroundOptions>(configuration.GetSection(PatternPlaygroundOptions.SectionName));
        services.AddSingleton<IFurnitureFactoryResolver, FurnitureFactoryResolver>();
        services.AddSingleton<AbstractFactoryShowcaseService>();
        return services;
    }
}

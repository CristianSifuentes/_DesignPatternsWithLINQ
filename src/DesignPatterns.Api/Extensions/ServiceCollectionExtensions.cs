using DesignPatterns.Api.Application;
using DesignPatterns.Api.Contracts;
using DesignPatterns.Api.Infrastructure.Creators;
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
        
        // Abstract Factory Pattern
        services.AddSingleton<IFurnitureFactoryResolver, FurnitureFactoryResolver>();
        services.AddSingleton<AbstractFactoryShowcaseService>();
        
        // Factory Method Pattern
        services.AddSingleton<ILogisticsResolver, LogisticsResolver>();
        services.AddSingleton<FactoryMethodShowcaseService>();
        
        return services;
    }
}

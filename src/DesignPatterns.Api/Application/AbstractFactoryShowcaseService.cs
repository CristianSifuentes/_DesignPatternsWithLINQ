using DesignPatterns.Api.Contracts;
using DesignPatterns.Api.Domain.AbstractFactory.Furniture;
using DesignPatterns.Api.Infrastructure.Factories;
using Microsoft.Extensions.Options;

namespace DesignPatterns.Api.Application;

public sealed class AbstractFactoryShowcaseService(
    IFurnitureFactoryResolver resolver,
    IOptions<PatternPlaygroundOptions> options)
{
    public FurnitureSet CreateConfiguredSet(string? style)
    {
        var selectedStyle = string.IsNullOrWhiteSpace(style) ? options.Value.DefaultStyle : style;
        var factory = resolver.Resolve(selectedStyle!);

        var chair = factory.CreateChair();
        var sofa = factory.CreateSofa();
        var table = factory.CreateCoffeeTable();

        return new FurnitureSet(
            factory.Style,
            chair.SitOn(),
            sofa.LieOn(),
            table.PlaceItem(),
            $"Todos los productos pertenecen a la familia {factory.Style} y son compatibles entre sí.");
    }

    public IReadOnlyCollection<string> GetSupportedStyles() => resolver.GetSupportedStyles();
}

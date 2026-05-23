using DesignPatterns.Api.Domain.AbstractFactory.Furniture;

namespace DesignPatterns.Api.Infrastructure.Factories;

public sealed class FurnitureFactoryResolver : IFurnitureFactoryResolver
{
    private static readonly IReadOnlyDictionary<string, IFurnitureFactory> Factories =
        new Dictionary<string, IFurnitureFactory>(StringComparer.OrdinalIgnoreCase)
        {
            ["Modern"] = new ModernFurnitureFactory(),
            ["Victorian"] = new VictorianFurnitureFactory(),
            ["ArtDeco"] = new ArtDecoFurnitureFactory()
        };

    public IFurnitureFactory Resolve(string style)
    {
        if (Factories.TryGetValue(style, out var factory)) return factory;

        throw new KeyNotFoundException($"Estilo '{style}' no soportado. Usa: {string.Join(", ", Factories.Keys)}");
    }

    public IReadOnlyCollection<string> GetSupportedStyles() => Factories.Keys.ToArray();
}

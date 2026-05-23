using DesignPatterns.Api.Domain.AbstractFactory.Furniture;

namespace DesignPatterns.Api.Infrastructure.Factories;

public interface IFurnitureFactoryResolver
{
    IFurnitureFactory Resolve(string style);
    IReadOnlyCollection<string> GetSupportedStyles();
}

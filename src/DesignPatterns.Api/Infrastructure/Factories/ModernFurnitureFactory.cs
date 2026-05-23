using DesignPatterns.Api.Domain.AbstractFactory.Furniture;

namespace DesignPatterns.Api.Infrastructure.Factories;

public sealed class ModernFurnitureFactory : IFurnitureFactory
{
    public string Style => "Modern";
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
    public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

    private sealed class ModernChair : IChair
    {
        public string SitOn() => "Silla moderna ergonómica con líneas minimalistas.";
    }

    private sealed class ModernSofa : ISofa
    {
        public string LieOn() => "Sofá moderno modular en tono neutro, pensado para espacios abiertos.";
    }

    private sealed class ModernCoffeeTable : ICoffeeTable
    {
        public string PlaceItem() => "Mesilla moderna de cristal templado y estructura metálica.";
    }
}

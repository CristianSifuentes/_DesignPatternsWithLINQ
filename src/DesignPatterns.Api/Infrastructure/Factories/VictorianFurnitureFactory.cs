using DesignPatterns.Api.Domain.AbstractFactory.Furniture;

namespace DesignPatterns.Api.Infrastructure.Factories;

public sealed class VictorianFurnitureFactory : IFurnitureFactory
{
    public string Style => "Victorian";
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();
    public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

    private sealed class VictorianChair : IChair
    {
        public string SitOn() => "Silla victoriana con respaldo alto y detalles tallados a mano.";
    }

    private sealed class VictorianSofa : ISofa
    {
        public string LieOn() => "Sofá victoriano capitoné con acabados de lujo y madera noble.";
    }

    private sealed class VictorianCoffeeTable : ICoffeeTable
    {
        public string PlaceItem() => "Mesilla victoriana ornamentada con patas curvadas y barniz oscuro.";
    }
}

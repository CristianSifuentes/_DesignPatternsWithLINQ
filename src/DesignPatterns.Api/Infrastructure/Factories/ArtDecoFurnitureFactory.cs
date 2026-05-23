using DesignPatterns.Api.Domain.AbstractFactory.Furniture;

namespace DesignPatterns.Api.Infrastructure.Factories;

public sealed class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public string Style => "ArtDeco";
    public IChair CreateChair() => new ArtDecoChair();
    public ISofa CreateSofa() => new ArtDecoSofa();
    public ICoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

    private sealed class ArtDecoChair : IChair
    {
        public string SitOn() => "Silla ArtDeco geométrica con tapizado de terciopelo.";
    }

    private sealed class ArtDecoSofa : ISofa
    {
        public string LieOn() => "Sofá ArtDeco de curvas elegantes y contraste dorado-negro.";
    }

    private sealed class ArtDecoCoffeeTable : ICoffeeTable
    {
        public string PlaceItem() => "Mesilla ArtDeco de mármol con acentos metálicos pulidos.";
    }
}

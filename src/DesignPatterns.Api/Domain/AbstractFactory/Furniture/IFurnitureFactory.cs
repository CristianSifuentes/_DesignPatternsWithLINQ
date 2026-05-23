namespace DesignPatterns.Api.Domain.AbstractFactory.Furniture;

public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ICoffeeTable CreateCoffeeTable();
    string Style { get; }
}

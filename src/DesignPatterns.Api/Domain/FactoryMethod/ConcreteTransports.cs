namespace DesignPatterns.Api.Domain.FactoryMethod;

/// <summary>
/// Concrete product: Truck for land transportation.
/// </summary>
public sealed class Truck : ITransport
{
    public string GetName() => "Truck";

    public string Deliver(string cargo, string destination)
        => $"Delivering '{cargo}' to {destination} by truck on highways. Road transport: ±5 days.";
}

/// <summary>
/// Concrete product: Ship for sea transportation.
/// </summary>
public sealed class Ship : ITransport
{
    public string GetName() => "Ship";

    public string Deliver(string cargo, string destination)
        => $"Delivering '{cargo}' to {destination} by ship across the seas. Sea transport: ±30 days.";
}

/// <summary>
/// Concrete product: Airplane for air transportation.
/// </summary>
public sealed class Airplane : ITransport
{
    public string GetName() => "Airplane";

    public string Deliver(string cargo, string destination)
        => $"Delivering '{cargo}' to {destination} by airplane. Air transport: ±2 days (express).";
}

/// <summary>
/// Concrete product: Train for rail transportation.
/// </summary>
public sealed class Train : ITransport
{
    public string GetName() => "Train";

    public string Deliver(string cargo, string destination)
        => $"Delivering '{cargo}' to {destination} by train on rails. Rail transport: ±10 days (bulk friendly).";
}

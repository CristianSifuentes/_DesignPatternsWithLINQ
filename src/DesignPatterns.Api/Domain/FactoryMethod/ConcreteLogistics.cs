namespace DesignPatterns.Api.Domain.FactoryMethod;

/// <summary>
/// Concrete Creator: Road-based logistics.
/// Overrides the factory method to create truck transport.
/// </summary>
public sealed class RoadLogistics : Logistics
{
    public override ITransport CreateTransport() => new Truck();

    protected override string GetLogisticsType() => "RoadLogistics";
}

/// <summary>
/// Concrete Creator: Sea-based logistics.
/// Overrides the factory method to create ship transport.
/// </summary>
public sealed class SeaLogistics : Logistics
{
    public override ITransport CreateTransport() => new Ship();

    protected override string GetLogisticsType() => "SeaLogistics";
}

/// <summary>
/// Concrete Creator: Air-based logistics.
/// Overrides the factory method to create airplane transport.
/// </summary>
public sealed class AirLogistics : Logistics
{
    public override ITransport CreateTransport() => new Airplane();

    protected override string GetLogisticsType() => "AirLogistics";
}

/// <summary>
/// Concrete Creator: Rail-based logistics.
/// Overrides the factory method to create train transport.
/// </summary>
public sealed class RailLogistics : Logistics
{
    public override ITransport CreateTransport() => new Train();

    protected override string GetLogisticsType() => "RailLogistics";
}

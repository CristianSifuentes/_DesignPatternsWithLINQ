namespace DesignPatterns.Api.Domain.FactoryMethod;

/// <summary>
/// Creator base class declaring the factory method.
/// Contains the core business logic for logistics operations.
/// Subclasses override the factory method to produce different transport types.
/// </summary>
public abstract class Logistics
{
    /// <summary>
    /// The factory method that subclasses must override.
    /// This method is responsible for creating the appropriate transport.
    /// </summary>
    public abstract ITransport CreateTransport();

    /// <summary>
    /// Core business logic that depends on products created by the factory method.
    /// This logic remains the same regardless of the transport type.
    /// </summary>
    public string PlanDelivery(string cargo, string destination)
    {
        var transport = CreateTransport();
        return $"[{GetLogisticsType()}] Using {transport.GetName()}: {transport.Deliver(cargo, destination)}";
    }

    /// <summary>
    /// Returns the type of logistics operation.
    /// Override in subclasses for meaningful context.
    /// </summary>
    protected abstract string GetLogisticsType();
}

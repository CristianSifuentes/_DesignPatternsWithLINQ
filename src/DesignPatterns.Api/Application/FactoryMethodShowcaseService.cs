using DesignPatterns.Api.Domain.FactoryMethod;
using DesignPatterns.Api.Infrastructure.Creators;

namespace DesignPatterns.Api.Application;

/// <summary>
/// Service that demonstrates the Factory Method pattern.
/// Shows how the pattern enables the creation of different transport objects
/// while keeping client code independent of concrete product classes.
/// </summary>
public sealed class FactoryMethodShowcaseService(ILogisticsResolver resolver)
{
    /// <summary>
    /// Plans a delivery using the specified logistics type.
    /// The client works through the abstract Creator (Logistics) interface,
    /// not knowing the concrete creator being used.
    /// </summary>
    public string PlanDelivery(string cargo, string destination, string transportType)
    {
        var logistics = resolver.Resolve(transportType);
        return logistics.PlanDelivery(cargo, destination);
    }

    /// <summary>
    /// Gets all available logistics/transport types.
    /// </summary>
    public IReadOnlyCollection<string> GetAvailableTransportTypes() => resolver.GetSupportedTypes();

    /// <summary>
    /// Demonstrates the flexibility of Factory Method by planning deliveries
    /// across multiple transport types without changing client code.
    /// </summary>
    public IReadOnlyCollection<string> GetMultiRouteComparison(string cargo, string destination)
    {
        var routes = new List<string>();
        foreach (var transportType in GetAvailableTransportTypes())
        {
            routes.Add(PlanDelivery(cargo, destination, transportType));
        }
        return routes.AsReadOnly();
    }
}

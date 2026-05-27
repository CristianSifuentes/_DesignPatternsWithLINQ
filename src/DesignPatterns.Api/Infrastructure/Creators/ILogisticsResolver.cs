using DesignPatterns.Api.Domain.FactoryMethod;

namespace DesignPatterns.Api.Infrastructure.Creators;

/// <summary>
/// Interface for resolving the appropriate logistics creator.
/// This resolver encapsulates the logic of selecting which concrete creator to instantiate.
/// </summary>
public interface ILogisticsResolver
{
    /// <summary>
    /// Resolves a logistics creator based on the transport type.
    /// </summary>
    /// <param name="transportType">Type of transport: 'Road', 'Sea', 'Air', or 'Rail'</param>
    /// <returns>An instance of the appropriate Logistics creator</returns>
    Logistics Resolve(string transportType);

    /// <summary>
    /// Gets all supported transport types.
    /// </summary>
    IReadOnlyCollection<string> GetSupportedTypes();
}

/// <summary>
/// Concrete resolver implementation for logistics creators.
/// Maintains a registry of available logistics types and provides factory resolution.
/// </summary>
public sealed class LogisticsResolver : ILogisticsResolver
{
    private static readonly IReadOnlyDictionary<string, Func<Logistics>> Creators =
        new Dictionary<string, Func<Logistics>>(StringComparer.OrdinalIgnoreCase)
        {
            ["Road"] = () => new RoadLogistics(),
            ["Sea"] = () => new SeaLogistics(),
            ["Air"] = () => new AirLogistics(),
            ["Rail"] = () => new RailLogistics()
        };

    public Logistics Resolve(string transportType)
    {
        if (Creators.TryGetValue(transportType, out var creator)) 
            return creator();

        throw new KeyNotFoundException(
            $"Transport type '{transportType}' not supported. Available: {string.Join(", ", Creators.Keys)}");
    }

    public IReadOnlyCollection<string> GetSupportedTypes() => Creators.Keys.ToArray();
}

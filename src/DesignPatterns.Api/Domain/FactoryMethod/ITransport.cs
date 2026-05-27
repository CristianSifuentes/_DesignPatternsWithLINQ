namespace DesignPatterns.Api.Domain.FactoryMethod;

/// <summary>
/// Product interface for the Factory Method pattern.
/// All concrete transports must implement this interface.
/// </summary>
public interface ITransport
{
    string GetName();
    string Deliver(string cargo, string destination);
}

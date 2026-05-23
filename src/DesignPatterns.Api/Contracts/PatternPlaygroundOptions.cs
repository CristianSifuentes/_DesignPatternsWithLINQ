namespace DesignPatterns.Api.Contracts;

public sealed class PatternPlaygroundOptions
{
    public const string SectionName = "PatternPlayground";
    public string DefaultStyle { get; set; } = "Modern";
}

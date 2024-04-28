namespace Attribinter.Parameters.Representations;

/// <summary>Represents some named parameter.</summary>
public interface INamedParameterRepresentation
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}

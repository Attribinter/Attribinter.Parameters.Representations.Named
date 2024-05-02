namespace Paraminter.Parameters.Representations;

/// <summary>Represents a named parameter.</summary>
public interface INamedParameterRepresentation
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}

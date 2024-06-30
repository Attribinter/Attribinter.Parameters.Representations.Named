namespace Paraminter.Parameters.Representations;

/// <summary>Represents a query for a named parameter representation, given the name of the named parameter.</summary>
public interface IGetNamedParameterRepresentationByNameQuery
    : IQuery
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}

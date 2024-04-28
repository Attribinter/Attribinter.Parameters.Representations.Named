namespace Attribinter.Parameters.Representations;

/// <summary>Handles creation of <see cref="INamedParameterRepresentation"/>.</summary>
public interface INamedParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="INamedParameterRepresentation"/>.</summary>
    /// <param name="name">The name of the named parameter.</param>
    /// <returns>The created <see cref="INamedParameterRepresentation"/>.</returns>
    public abstract INamedParameterRepresentation Create(string name);
}

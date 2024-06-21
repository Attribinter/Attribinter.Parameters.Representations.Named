namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="INamedParameterRepresentation"/>.</summary>
public interface INamedParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="INamedParameterRepresentation"/>.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of named parameters.</param>
    /// <returns>The created comparer of <see cref="INamedParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<INamedParameterRepresentation> Create(
        IEqualityComparer<string> nameComparer);
}

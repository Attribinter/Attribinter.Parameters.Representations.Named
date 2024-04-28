namespace Attribinter.Parameters.Representations;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="INamedParameterRepresentationEqualityComparerFactory"/>
public sealed class NamedParameterRepresentationEqualityComparerFactory : INamedParameterRepresentationEqualityComparerFactory
{
    /// <summary>Instantiates a <see cref="NamedParameterRepresentationEqualityComparerFactory"/>, handling creation of comparers of <see cref="INamedParameterRepresentation"/>.</summary>
    public NamedParameterRepresentationEqualityComparerFactory() { }

    IEqualityComparer<INamedParameterRepresentation> INamedParameterRepresentationEqualityComparerFactory.Create(IEqualityComparer<string> nameComparer)
    {
        if (nameComparer is null)
        {
            throw new ArgumentNullException(nameof(nameComparer));
        }

        return new NamedParameterRepresentationEqualityComparer(nameComparer);
    }

    private sealed class NamedParameterRepresentationEqualityComparer : IEqualityComparer<INamedParameterRepresentation>
    {
        private readonly IEqualityComparer<string> NameComparer;

        public NamedParameterRepresentationEqualityComparer(IEqualityComparer<string> nameComparer)
        {
            NameComparer = nameComparer;
        }

        bool IEqualityComparer<INamedParameterRepresentation>.Equals(INamedParameterRepresentation x, INamedParameterRepresentation y)
        {
            if (x is null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y is null)
            {
                throw new ArgumentNullException(nameof(y));
            }

            return NameComparer.Equals(x.Name, y.Name);
        }

        int IEqualityComparer<INamedParameterRepresentation>.GetHashCode(INamedParameterRepresentation obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return NameComparer.GetHashCode(obj.Name);
        }
    }
}

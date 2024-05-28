namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="INamedParameterRepresentationFactory"/>
public sealed class NamedParameterRepresentationFactory
    : INamedParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="NamedParameterRepresentationFactory"/>, handling creation of <see cref="INamedParameterRepresentation"/>.</summary>
    public NamedParameterRepresentationFactory() { }

    INamedParameterRepresentation INamedParameterRepresentationFactory.Create(
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new NamedParameterRepresentation(name);
    }

    private sealed class NamedParameterRepresentation
        : INamedParameterRepresentation
    {
        private readonly string Name;

        public NamedParameterRepresentation(
            string name)
        {
            Name = name;
        }

        string INamedParameterRepresentation.Name => Name;
    }
}

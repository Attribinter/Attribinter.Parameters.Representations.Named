namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetNamedParameterRepresentationByNameQuery"/>, and responds with <see cref="INamedParameterRepresentation"/>.</summary>
public sealed class GetNamedParameterRepresentationByNameQueryHandller
    : IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="GetNamedParameterRepresentationByNameQueryHandller"/>, handling <see cref="IGetNamedParameterRepresentationByNameQuery"/>.</summary>
    public GetNamedParameterRepresentationByNameQueryHandller() { }

    INamedParameterRepresentation IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>.Handle(
        IGetNamedParameterRepresentationByNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new NamedParameterRepresentation(query.Name);
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

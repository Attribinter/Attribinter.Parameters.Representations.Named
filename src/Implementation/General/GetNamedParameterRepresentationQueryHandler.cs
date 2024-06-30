namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetParameterRepresentationQuery{TParameter}"/>, and responds with <see cref="INamedParameterRepresentation"/>.</summary>
public sealed class GetNamedParameterRepresentationQueryHandler
    : IQueryHandler<IGetParameterRepresentationQuery<INamedParameter>, INamedParameterRepresentation>
{
    private readonly IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> ByNameQueryHandler;

    /// <summary>Instantiates a <see cref="GetNamedParameterRepresentationQueryHandler"/>, handling <see cref="IGetParameterRepresentationQuery{TParameter}"/>.</summary>
    /// <param name="byNameQueryHandler">Handles creation of <see cref="INamedParameterRepresentation"/>.</param>
    public GetNamedParameterRepresentationQueryHandler(
        IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> byNameQueryHandler)
    {
        ByNameQueryHandler = byNameQueryHandler ?? throw new ArgumentNullException(nameof(byNameQueryHandler));
    }

    INamedParameterRepresentation IQueryHandler<IGetParameterRepresentationQuery<INamedParameter>, INamedParameterRepresentation>.Handle(
        IGetParameterRepresentationQuery<INamedParameter> query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        var byNameQuery = GetNamedParameterRepresentationByNameQueryFactory.FromParameter(query.Parameter);

        return ByNameQueryHandler.Handle(byNameQuery);
    }
}

namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IQueryHandler<IGetParameterRepresentationQuery<INamedParameter>, INamedParameterRepresentation> Sut { get; }

    public abstract Mock<IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>> ByNameQueryHandlerMock { get; }
}

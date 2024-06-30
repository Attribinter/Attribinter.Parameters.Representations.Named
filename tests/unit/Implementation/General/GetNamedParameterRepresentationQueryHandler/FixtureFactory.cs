namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>> byNameQueryHandlerMock = new();

        var sut = new GetNamedParameterRepresentationQueryHandler(byNameQueryHandlerMock.Object);

        return new Fixture(sut, byNameQueryHandlerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetParameterRepresentationQuery<INamedParameter>, INamedParameterRepresentation> Sut;

        private readonly Mock<IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>> ByNameQueryHandlerMock;

        public Fixture(
            IQueryHandler<IGetParameterRepresentationQuery<INamedParameter>, INamedParameterRepresentation> sut,
            Mock<IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>> byNameQueryHandlerMock)
        {
            Sut = sut;

            ByNameQueryHandlerMock = byNameQueryHandlerMock;
        }

        IQueryHandler<IGetParameterRepresentationQuery<INamedParameter>, INamedParameterRepresentation> IFixture.Sut => Sut;

        Mock<IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>> IFixture.ByNameQueryHandlerMock => ByNameQueryHandlerMock;
    }
}

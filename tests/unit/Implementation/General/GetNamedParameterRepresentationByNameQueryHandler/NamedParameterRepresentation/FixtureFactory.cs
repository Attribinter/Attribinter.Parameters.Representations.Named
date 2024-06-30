namespace Paraminter.Parameters.Representations.NamedParameterRepresentation;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create(
        string name)
    {
        Mock<IGetNamedParameterRepresentationByNameQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Name).Returns(name);

        IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> factory = new GetNamedParameterRepresentationByNameQueryHandller();

        var sut = factory.Handle(queryMock.Object);

        return new Fixture(sut, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedParameterRepresentation Sut;

        private readonly string Name;

        public Fixture(
            INamedParameterRepresentation sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        INamedParameterRepresentation IFixture.Sut => Sut;

        string IFixture.Name => Name;
    }
}

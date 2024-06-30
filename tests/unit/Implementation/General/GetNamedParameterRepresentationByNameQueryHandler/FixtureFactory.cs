namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetNamedParameterRepresentationByNameQueryHandller sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> Sut;

        public Fixture(
            IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> IFixture.Sut => Sut;
    }
}

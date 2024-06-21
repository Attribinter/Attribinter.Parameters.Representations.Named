namespace Paraminter.Parameters.Representations.NamedParameterRepresentation;

internal static class FixtureFactory
{
    public static IFixture Create(
        string name)
    {
        INamedParameterRepresentationFactory factory = new NamedParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedParameterRepresentation Sut;

        public Fixture(
            INamedParameterRepresentation sut)
        {
            Sut = sut;
        }

        INamedParameterRepresentation IFixture.Sut => Sut;
    }
}

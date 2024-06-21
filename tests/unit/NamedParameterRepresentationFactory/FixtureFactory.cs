namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        NamedParameterRepresentationFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedParameterRepresentationFactory Sut;

        public Fixture(
            INamedParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        INamedParameterRepresentationFactory IFixture.Sut => Sut;
    }
}

namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        NamedParameterRepresentationEqualityComparerFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedParameterRepresentationEqualityComparerFactory Sut;

        public Fixture(
            INamedParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        INamedParameterRepresentationEqualityComparerFactory IFixture.Sut => Sut;
    }
}

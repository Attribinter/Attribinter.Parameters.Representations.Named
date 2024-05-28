namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NamedParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture
        : IFactoryFixture
    {
        private readonly INamedParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(
            INamedParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        INamedParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}

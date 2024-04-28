namespace Attribinter.Parameters.Representations.NamedParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NamedParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INamedParameterRepresentationFactory Sut;

        public FactoryFixture(INamedParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        INamedParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}

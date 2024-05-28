namespace Paraminter.Parameters.Representations.NamedParameterRepresentationFactoryCases.NamedParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(
        string name)
    {
        INamedParameterRepresentationFactory factory = new NamedParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new RepresentationFixture(sut);
    }

    private sealed class RepresentationFixture
        : IRepresentationFixture
    {
        private readonly INamedParameterRepresentation Sut;

        public RepresentationFixture(
            INamedParameterRepresentation sut)
        {
            Sut = sut;
        }

        INamedParameterRepresentation IRepresentationFixture.Sut => Sut;
    }
}

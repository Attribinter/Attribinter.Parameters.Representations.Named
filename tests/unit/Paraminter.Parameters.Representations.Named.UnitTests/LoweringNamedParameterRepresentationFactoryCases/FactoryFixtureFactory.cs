namespace Paraminter.Parameters.Representations.LoweringNamedParameterRepresentationFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<INamedParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringNamedParameterRepresentationFactory(innerFactoryMock.Object);

        return new FactoryFixture(sut, innerFactoryMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> Sut;

        private readonly Mock<INamedParameterRepresentationFactory> InnerFactoryMock;

        public FactoryFixture(IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> sut, Mock<INamedParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> IFactoryFixture.Sut => Sut;

        Mock<INamedParameterRepresentationFactory> IFactoryFixture.InnerFactoryMock => InnerFactoryMock;
    }
}

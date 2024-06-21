namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<INamedParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringNamedParameterRepresentationFactory(innerFactoryMock.Object);

        return new Fixture(sut, innerFactoryMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> Sut;

        private readonly Mock<INamedParameterRepresentationFactory> InnerFactoryMock;

        public Fixture(
            IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> sut,
            Mock<INamedParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> IFixture.Sut => Sut;

        Mock<INamedParameterRepresentationFactory> IFixture.InnerFactoryMock => InnerFactoryMock;
    }
}

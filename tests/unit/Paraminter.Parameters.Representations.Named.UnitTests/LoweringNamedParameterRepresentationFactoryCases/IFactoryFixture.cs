namespace Paraminter.Parameters.Representations.LoweringNamedParameterRepresentationFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> Sut { get; }

    public abstract Mock<INamedParameterRepresentationFactory> InnerFactoryMock { get; }
}

namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation> Sut { get; }

    public abstract Mock<INamedParameterRepresentationFactory> InnerFactoryMock { get; }
}

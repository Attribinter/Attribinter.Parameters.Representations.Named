namespace Paraminter.Parameters.Representations.LoweringNamedParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private INamedParameterRepresentation Target(INamedParameter parameter) => Fixture.Sut.Create(parameter);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullParameter_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidParameter_ReturnsRepresentation()
    {
        var representation = Mock.Of<INamedParameterRepresentation>();

        var name = "Name";

        Mock<INamedParameter> parameterMock = new();

        parameterMock.Setup(static (parameter) => parameter.Name).Returns(name);

        Fixture.InnerFactoryMock.Setup((factory) => factory.Create(name)).Returns(representation);

        var result = Target(parameterMock.Object);

        Assert.Same(representation, result);
    }
}

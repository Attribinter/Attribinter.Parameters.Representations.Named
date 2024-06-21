namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparer;

using Moq;

using System;

using Xunit;

public sealed class Equals
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullX_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<INamedParameterRepresentation>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullY_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<INamedParameterRepresentation>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void FalseReturningNameComparer_ReturnsFalse() => PropagatesReturnValue(false);

    [Fact]
    public void TrueReturningNameComparer_ReturnsTrue() => PropagatesReturnValue(true);

    private void PropagatesReturnValue(
        bool returnValue)
    {
        var xName = "NameX";
        var yName = "NameY";

        Mock<INamedParameterRepresentation> xMock = new();
        Mock<INamedParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.Name).Returns(xName);
        yMock.Setup(static (representation) => representation.Name).Returns(yName);

        Fixture.NameComparerMock.Setup((comparer) => comparer.Equals(xName, yName)).Returns(returnValue);

        var result = Target(xMock.Object, yMock.Object);

        Assert.Equal(returnValue, result);
    }

    private bool Target(
        INamedParameterRepresentation x,
        INamedParameterRepresentation y)
    {
        return Fixture.Sut.Equals(x, y);
    }
}

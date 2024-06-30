namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Handle
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullQuery_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidQuery_ReturnsRepresentation()
    {
        var result = Target(Mock.Of<IGetNamedParameterRepresentationByNameQuery>());

        Assert.NotNull(result);
    }

    private INamedParameterRepresentation Target(
        IGetNamedParameterRepresentationByNameQuery query)
    {
        return Fixture.Sut.Handle(query);
    }
}

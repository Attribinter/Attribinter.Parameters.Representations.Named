namespace Paraminter.Parameters.Representations;

using Moq;

using System;
using System.Linq.Expressions;

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
        var representation = Mock.Of<INamedParameterRepresentation>();

        var name = "Name";

        Mock<INamedParameter> parameterMock = new();
        Mock<IGetParameterRepresentationQuery<INamedParameter>> queryMock = new();

        parameterMock.Setup(static (parameter) => parameter.Name).Returns(name);

        queryMock.Setup(static (query) => query.Parameter).Returns(parameterMock.Object);

        Fixture.ByNameQueryHandlerMock.Setup((factory) => factory.Handle(It.Is(CreateByNameQueryMatcher(name)))).Returns(representation);

        var result = Target(queryMock.Object);

        Assert.Same(representation, result);
    }

    private static Expression<Func<IGetNamedParameterRepresentationByNameQuery, bool>> CreateByNameQueryMatcher(
        string name)
    {
        return (query) => query.Name == name;
    }

    private INamedParameterRepresentation Target(
        IGetParameterRepresentationQuery<INamedParameter> query)
    {
        return Fixture.Sut.Handle(query);
    }
}

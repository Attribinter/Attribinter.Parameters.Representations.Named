namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullByNameQueryHandler_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidByNameQueryHandler_ReturnsFactory()
    {
        var result = Target(Mock.Of<IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation>>());

        Assert.NotNull(result);
    }

    private static GetNamedParameterRepresentationQueryHandler Target(
        IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> byNameQueryHandler)
    {
        return new GetNamedParameterRepresentationQueryHandler(byNameQueryHandler);
    }
}

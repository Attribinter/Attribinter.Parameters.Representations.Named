namespace Paraminter.Parameters.Representations.LoweringNamedParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullInnerFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidInnerFactory_ReturnsFactory()
    {
        var result = Target(Mock.Of<INamedParameterRepresentationFactory>());

        Assert.NotNull(result);
    }

    private static LoweringNamedParameterRepresentationFactory Target(INamedParameterRepresentationFactory innerFactory) => new(innerFactory);
}

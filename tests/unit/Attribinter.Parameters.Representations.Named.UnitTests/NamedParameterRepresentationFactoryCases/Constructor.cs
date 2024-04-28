﻿namespace Attribinter.Parameters.Representations.NamedParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static NamedParameterRepresentationFactory Target() => new();
}

namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static NamedParameterRepresentationEqualityComparerFactory Target() => new();
}

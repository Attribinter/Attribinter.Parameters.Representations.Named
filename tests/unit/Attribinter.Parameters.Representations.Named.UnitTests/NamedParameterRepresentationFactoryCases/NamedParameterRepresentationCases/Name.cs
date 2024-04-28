namespace Attribinter.Parameters.Representations.NamedParameterRepresentationFactoryCases.NamedParameterRepresentationCases;

using Xunit;

public sealed class Name
{
    [Fact]
    public void ReturnsNameConstructedWith()
    {
        var expected = "Name";

        var fixture = RepresentationFixtureFactory.Create(expected);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static string Target(IRepresentationFixture fixture) => fixture.Sut.Name;
}

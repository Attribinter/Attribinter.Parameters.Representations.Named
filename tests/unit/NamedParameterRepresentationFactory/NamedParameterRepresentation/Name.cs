namespace Paraminter.Parameters.Representations.NamedParameterRepresentation;

using Xunit;

public sealed class Name
{
    [Fact]
    public void ReturnsName()
    {
        var expected = "Name";

        var fixture = FixtureFactory.Create(expected);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static string Target(
        IFixture fixture)
    {
        return fixture.Sut.Name;
    }
}

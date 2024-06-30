namespace Paraminter.Parameters.Representations.NamedParameterRepresentation;

using Xunit;

public sealed class Name
{
    [Fact]
    public void ReturnsName()
    {
        var fixture = FixtureFactory.Create("Name");

        var result = Target(fixture);

        Assert.Equal(fixture.Name, result);
    }

    private static string Target(
        IFixture fixture)
    {
        return fixture.Sut.Name;
    }
}

namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparerFactoryCases;

using Moq;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class Create
{
    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullNameComparer_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidNameComparer_ReturnsComparer()
    {
        var result = Target(Mock.Of<IEqualityComparer<string>>());

        Assert.NotNull(result);
    }

    private IEqualityComparer<INamedParameterRepresentation> Target(
        IEqualityComparer<string> nameComparer)
    {
        return Fixture.Sut.Create(nameComparer);
    }
}

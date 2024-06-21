namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparer;

using Moq;

using System.Collections.Generic;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        INamedParameterRepresentationEqualityComparerFactory factory = new NamedParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new Fixture(sut, nameComparerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IEqualityComparer<INamedParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public Fixture(
            IEqualityComparer<INamedParameterRepresentation> sut,
            Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;
            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<INamedParameterRepresentation> IFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IFixture.NameComparerMock => NameComparerMock;
    }
}

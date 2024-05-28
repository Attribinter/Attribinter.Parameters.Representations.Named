namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparerFactoryCases.NamedParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal static class ComparerFixtureFactory
{
    public static IComparerFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        INamedParameterRepresentationEqualityComparerFactory factory = new NamedParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new ComparerFixture(sut, nameComparerMock);
    }

    private sealed class ComparerFixture
        : IComparerFixture
    {
        private readonly IEqualityComparer<INamedParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public ComparerFixture(
            IEqualityComparer<INamedParameterRepresentation> sut,
            Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;
            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<INamedParameterRepresentation> IComparerFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IComparerFixture.NameComparerMock => NameComparerMock;
    }
}

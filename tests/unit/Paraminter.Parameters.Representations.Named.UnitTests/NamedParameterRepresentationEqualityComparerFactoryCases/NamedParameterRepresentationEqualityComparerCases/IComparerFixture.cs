namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparerFactoryCases.NamedParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal interface IComparerFixture
{
    public abstract IEqualityComparer<INamedParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}

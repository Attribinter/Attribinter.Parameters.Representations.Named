namespace Paraminter.Parameters.Representations.NamedParameterRepresentationEqualityComparer;

using Moq;

using System.Collections.Generic;

internal interface IFixture
{
    public abstract IEqualityComparer<INamedParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}

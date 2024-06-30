namespace Paraminter.Parameters.Representations.NamedParameterRepresentation;

internal interface IFixture
{
    public abstract INamedParameterRepresentation Sut { get; }

    public abstract string Name { get; }
}

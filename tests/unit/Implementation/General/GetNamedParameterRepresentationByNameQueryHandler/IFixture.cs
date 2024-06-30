namespace Paraminter.Parameters.Representations;

internal interface IFixture
{
    public abstract IQueryHandler<IGetNamedParameterRepresentationByNameQuery, INamedParameterRepresentation> Sut { get; }
}

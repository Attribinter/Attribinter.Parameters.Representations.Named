namespace Paraminter.Parameters.Representations;

internal static class GetNamedParameterRepresentationByNameQueryFactory
{
    public static IGetNamedParameterRepresentationByNameQuery FromParameter(
        INamedParameter parameter)
    {
        return new GetNamedParameterRepresentationByNameQuery(parameter.Name);
    }

    private sealed record class GetNamedParameterRepresentationByNameQuery
        : IGetNamedParameterRepresentationByNameQuery
    {
        private readonly string Name;

        public GetNamedParameterRepresentationByNameQuery(
            string name)
        {
            Name = name;
        }

        string IGetNamedParameterRepresentationByNameQuery.Name => Name;
    }
}

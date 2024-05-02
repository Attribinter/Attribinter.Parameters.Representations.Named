namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="INamedParameterRepresentation"/> using <see cref="INamedParameter"/>.</summary>
public sealed class LoweringNamedParameterRepresentationFactory : IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation>
{
    private readonly INamedParameterRepresentationFactory InnerFactory;

    /// <summary>Instantiates a <see cref="LoweringNamedParameterRepresentationFactory"/>, handling creation of <see cref="INamedParameterRepresentation"/> using <see cref="INamedParameter"/>.</summary>
    /// <param name="innerFactory">Handles creation of <see cref="INamedParameterRepresentation"/> using the indices and names of type parameters.</param>
    public LoweringNamedParameterRepresentationFactory(INamedParameterRepresentationFactory innerFactory)
    {
        InnerFactory = innerFactory ?? throw new ArgumentNullException(nameof(innerFactory));
    }

    INamedParameterRepresentation IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation>.Create(INamedParameter parameter)
    {
        if (parameter is null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }

        return InnerFactory.Create(parameter.Name);
    }
}

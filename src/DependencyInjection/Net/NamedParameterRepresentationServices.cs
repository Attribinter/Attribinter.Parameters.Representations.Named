namespace Paraminter.Parameters.Representations;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>Paraminter.Parameters.Representations.Named</i> to be registered with a <see cref="IServiceCollection"/>.</summary>
public static class NamedParameterRepresentationServices
{
    /// <summary>Registers the services provided by <i>Paraminter.Parameters.Representations.Named</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddParaminterNamedParameterRepresentations(
        this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<INamedParameterRepresentationEqualityComparerFactory, NamedParameterRepresentationEqualityComparerFactory>();
        services.AddTransient<INamedParameterRepresentationFactory, NamedParameterRepresentationFactory>();

        services.AddTransient<IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation>, LoweringNamedParameterRepresentationFactory>();

        return services;
    }
}

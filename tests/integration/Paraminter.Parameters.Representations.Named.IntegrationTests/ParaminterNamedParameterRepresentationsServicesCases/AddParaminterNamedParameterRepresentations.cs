namespace Paraminter.Parameters.Representations.ParaminterNamedParameterRepresentationsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using System;

using Xunit;

public sealed class AddParaminterNamedParameterRepresentations
{
    [Fact]
    public void NullServiceCollection_ArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var services = Mock.Of<IServiceCollection>();

        var result = Target(services);

        Assert.Same(services, result);
    }

    [Fact]
    public void INamedParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void INamedParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedParameterRepresentationFactory>();

    [Fact]
    public void IParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IParameterRepresentationFactory<INamedParameter, INamedParameterRepresentation>>();

    private static IServiceCollection Target(IServiceCollection services) => ParaminterNamedParameterRepresentationsServices.AddParaminterNamedParameterRepresentations(services);

    [AssertionMethod]
    private static void ServiceCanBeResolved<TService>()
        where TService : notnull
    {
        HostBuilder host = new();

        host.ConfigureServices(static (services) => Target(services));

        var serviceProvider = host.Build().Services;

        var result = serviceProvider.GetRequiredService<TService>();

        Assert.NotNull(result);
    }
}

using APIsEndpointsAutoRegistering.Endpoints.Common;

namespace APIsEndpointsAutoRegistering;

public static class EndpointRegistrationExtensions
{
    public static void RegisterAllEndpoints(this IEndpointRouteBuilder app)
    {
        var endpointDefinitions = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => typeof(IEndpoint).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
            .Select(Activator.CreateInstance)
            .Cast<IEndpoint>();

        foreach (var endpoint in endpointDefinitions)
        {
            endpoint.RegisterEndpoints(app);
        }
    }
}
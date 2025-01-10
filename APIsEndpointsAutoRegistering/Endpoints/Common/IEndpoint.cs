namespace APIsEndpointsAutoRegistering.Endpoints.Common;

public interface IEndpoint
{
    void RegisterEndpoints(IEndpointRouteBuilder endpoints);
}

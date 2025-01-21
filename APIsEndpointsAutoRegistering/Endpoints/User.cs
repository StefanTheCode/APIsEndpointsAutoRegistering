using APIsEndpointsAutoRegistering.Endpoints.Common;

namespace APIsEndpointsAutoRegistering.Endpoints;

public class UserEndpoint : IEndpoint
{
    public void RegisterEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/users", (string name) => Results.Ok($"User {name} created!"));
        endpoints.MapGet("/users", () => Results.Ok(new List<string> { "User 1", "User 2" }));
        endpoints.MapGet("/users/test", () => Results.Ok("Test"));
    }
}
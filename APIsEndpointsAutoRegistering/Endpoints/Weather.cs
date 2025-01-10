using APIsEndpointsAutoRegistering.Endpoints.Common;

namespace APIsEndpointsAutoRegistering.Endpoints;

public class WeatherEndpoint : IEndpoint
{
    private static readonly string[] handler = ["Sunny", "Cloudy", "Rainy"];

    public void RegisterEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/weather", () => handler);
    }
}
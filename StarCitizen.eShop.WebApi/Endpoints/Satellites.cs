using Carter;
using MediatR;
using StarCitizen.eShop.Application.UserCases.Satellites.Create;

namespace StarCitizen.eShop.WebApi.Endpoints;

public class Satellites : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("satellites", async (CreateSatelliteCommand command, ISender sender) =>
        {
            await sender.Send(command);
            return Results.Ok();
        });
    }
}

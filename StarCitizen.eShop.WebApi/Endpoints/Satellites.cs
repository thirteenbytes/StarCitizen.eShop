using Carter;
using MediatR;
using StarCitizen.eShop.Application.UseCases.Satellites.Create;
using StarCitizen.eShop.Application.UseCases.Satellites;
using StarCitizen.eShop.Domain.Satellites;
using StarCitizen.eShop.Application.UseCases.Satellites.Read;
using Microsoft.AspNetCore.Mvc;
using StarCitizen.eShop.Application.UseCases.Satellites.Update;
using StarCitizen.eShop.Application.UseCases.Satellites.Delete;

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

        app.MapGet("satellites/{id:guid}", async (Guid id, ISender sender) =>
        {
            try
            {
                return Results.Ok(await sender.Send(new ReadSatelliteQuery(new SatelliteId(id))));
            }
            catch (SatelliteNotFoundExpection ex)
            {
                return Results.NotFound(ex.Message);
            }
        });

        app.MapGet("satellites", async (ISender sender) =>
        {
            return Results.Ok(await sender.Send(new ReadSatellitesQuery()));
        });

        app.MapPut("satellites/{id:guid}", async (Guid id, [FromBody] UpdateSatelliteRequest request, ISender sender) =>
        {
            var command = new UpdateSatelliteCommand(new SatelliteId(id), request.Name, request.Description, request.Type);

            await sender.Send(command);

            return Results.NoContent();
        });

        app.MapDelete("satellites/{id:guid}", async (Guid id, ISender sender) =>
        {
            try
            {
                await sender.Send(new DeleteSatelliteCommand(new SatelliteId(id)));
                return Results.NoContent();
            }
            catch (SatelliteNotFoundExpection ex)
            {
                return Results.NotFound(ex.Message);
            }
        });
    }
}

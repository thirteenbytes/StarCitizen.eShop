using Carter;
using MediatR;
using StarCitizen.eShop.Application.UseCases.Items.ArmorItems.Create;

namespace StarCitizen.eShop.WebApi.Endpoints;

public class Armors : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("armors", async (CreateArmorCommand command, ISender sender) =>
        {
            await sender.Send(command);
            return Results.Ok();
        });
    }
}

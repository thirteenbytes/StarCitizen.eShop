using MediatR;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Create;

public record CreateSatelliteCommand(string Name, string Description, string Type) : IRequest;

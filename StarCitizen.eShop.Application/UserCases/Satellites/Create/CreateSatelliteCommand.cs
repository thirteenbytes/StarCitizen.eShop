using MediatR;

namespace StarCitizen.eShop.Application.UserCases.Satellites.Create;

public record CreateSatelliteCommand(string Name, string Description, string Type) : IRequest;

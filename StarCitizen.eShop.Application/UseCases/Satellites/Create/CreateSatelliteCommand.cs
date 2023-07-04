using MediatR;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Create;

public record CreateSatelliteCommand(string Name, string Description, string Type, SatelliteId parentId) : IRequest;

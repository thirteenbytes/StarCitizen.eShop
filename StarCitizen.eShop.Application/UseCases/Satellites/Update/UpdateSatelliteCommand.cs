using MediatR;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Update;

public record UpdateSatelliteCommand(SatelliteId SatelliteId, string Name, string Description, string Type, SatelliteId ParentId) : IRequest;

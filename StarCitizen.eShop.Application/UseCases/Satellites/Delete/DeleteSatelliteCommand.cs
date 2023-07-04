using MediatR;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Delete;

public record DeleteSatelliteCommand(SatelliteId SatelliteId) : IRequest;

using MediatR;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites;

public record ReadSatelliteQuery(SatelliteId satelliteId) : IRequest<SatelliteResponse>;

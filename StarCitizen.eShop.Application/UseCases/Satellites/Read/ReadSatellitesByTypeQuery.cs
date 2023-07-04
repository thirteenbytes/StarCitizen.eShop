using MediatR;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Read;

public record ReadSatellitesByTypeQuery(SatelliteType SatelliteType) : IRequest<IEnumerable<SatelliteResponse>>;

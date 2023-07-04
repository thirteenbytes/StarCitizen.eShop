using MediatR;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Read;

public record ReadSatellitesQuery() : IRequest<IEnumerable<SatelliteResponse>>;

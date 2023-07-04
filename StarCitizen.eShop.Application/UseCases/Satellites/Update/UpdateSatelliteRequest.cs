using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Update;

public record UpdateSatelliteRequest(string Name, string Description, string Type, SatelliteId ParentId);

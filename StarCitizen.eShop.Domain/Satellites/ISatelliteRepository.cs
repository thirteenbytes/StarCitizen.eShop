namespace StarCitizen.eShop.Domain.Satellites;

public interface ISatelliteRepository
{
    Task<Satellite> GetByIdAsync(SatelliteId id);
}

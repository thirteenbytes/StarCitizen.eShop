namespace StarCitizen.eShop.Domain.Satellites;

public interface ISatelliteRepository
{
    Task<Satellite> GetByIdAsync(SatelliteId id);
    void Add(Satellite satellite);
    void Update(Satellite satellite);
    void Delete(Satellite satellite);
}

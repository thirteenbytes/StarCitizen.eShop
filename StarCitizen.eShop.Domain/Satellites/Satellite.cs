namespace StarCitizen.eShop.Domain.Satellites;

public class Satellite
{
    public SatelliteId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public SatelliteType SatelliteType { get; private set; }
    public Satellite ParentSatellite { get; private set; } = null!;
}

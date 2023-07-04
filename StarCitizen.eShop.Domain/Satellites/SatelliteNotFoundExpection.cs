namespace StarCitizen.eShop.Domain.Satellites;

public sealed class SatelliteNotFoundExpection : Exception
{
    public SatelliteNotFoundExpection(SatelliteId id)
        : base($"The satellite with Id = {id.Value} was not found") { }
}

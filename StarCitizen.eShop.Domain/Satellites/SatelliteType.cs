namespace StarCitizen.eShop.Domain.Satellites;

public record SatelliteType(SatelliteTypeEnum Value);

public enum SatelliteTypeEnum
{
    System = 1,
    Planet = 2,
    Moon = 3,
    SpaceStation = 4
}

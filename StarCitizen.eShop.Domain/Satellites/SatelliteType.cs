namespace StarCitizen.eShop.Domain.Satellites;

public record SatelliteType
{
    private SatelliteType(SatelliteTypeEnum value) =>
        Value = value;
    
    public SatelliteTypeEnum Value { get; init; }

    public static SatelliteType Create(string value)
    {
        bool result = Enum.TryParse(value, out SatelliteTypeEnum enumValue);

        if (!result) throw new Exception("Not found");

        return new SatelliteType(enumValue);
    }
}

public enum SatelliteTypeEnum
{
    System = 1,
    Planet = 2,
    Moon = 3,
    SpaceStation = 4
}

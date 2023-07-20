using System.ComponentModel;

namespace StarCitizen.eShop.Domain.Facilities;

public sealed record FacilityType
{
    private FacilityType(FacilityTypeEnum value) =>
        Value = value;

    public FacilityTypeEnum Value { get; init; }

    public static FacilityType Set(string value)
    {
        var result = Enum.TryParse(value, out FacilityTypeEnum enumValue);
        if (!result) throw new Exception();

        return new FacilityType(enumValue);
    }
}

public enum FacilityTypeEnum
{

    [Description("Convention center")]
    ConventionCenter,

    [Description("Hospital")]
    Hospital,

    [Description("Industrial and commerical zone")]
    IndustrialAndCommericalZone,

    [Description("Lounge")]
    Lounge,

    [Description("Outpost")]
    Outpost,

    [Description("Public shelter")]
    PublicShelter,

    [Description("Rental")]
    Rental,

    [Description("Scrapyard")]
    Scrapyard,

    [Description("Space station")]
    SpaceStation,

    [Description("Space port")]
    Spaceport,

    [Description("Store")]
    Store
}

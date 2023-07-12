namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public record ArmorType
{
    private ArmorType(ArmorTypeEnum value) =>
        Value = value;

    public ArmorTypeEnum Value { get; init; }

    public static ArmorType Create(string value)
    {
        bool result = Enum.TryParse(value, out ArmorTypeEnum enumValue);

        if (!result) throw new Exception(value);

        return new ArmorType(enumValue);
    }
}

public enum ArmorTypeEnum
{
    Flight = 0,
    Light = 1,
    Medium = 2,
    Heavy = 3,
}

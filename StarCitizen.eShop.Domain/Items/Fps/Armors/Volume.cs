namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public record Volume
{
    public Volume(decimal value) =>
        Value = value;

    public Volume() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static Volume NotApplicle = new Volume { InUse = false };    

    public static Volume Create(decimal value)
    {
        if (value < 0) throw new ArgumentOutOfRangeException($"{value}");
        return new Volume(value);
    }

}

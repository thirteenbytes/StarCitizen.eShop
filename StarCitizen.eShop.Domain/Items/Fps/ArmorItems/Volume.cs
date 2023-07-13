namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public record Volume
{
    private Volume(decimal value) =>
        Value = value;

    private Volume() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static Volume NotApplicable = new Volume { InUse = false };    

    public static Volume Create(decimal? value)
    {
        if (value.HasValue)
        {

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{value}");
            }
            return new Volume(value.Value);
        }
        return NotApplicable;
    }

}

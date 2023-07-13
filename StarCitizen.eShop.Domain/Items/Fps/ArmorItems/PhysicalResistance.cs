namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public record PhysicalResistance
{
    private PhysicalResistance(decimal value) =>
        Value = value;

    private PhysicalResistance() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static PhysicalResistance NotApplicable = new PhysicalResistance { InUse = false };

    public static PhysicalResistance Create(decimal? value)
    {
        if (value.HasValue)
        {

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            return new PhysicalResistance(value.Value);
        }

        return NotApplicable;
    }

}

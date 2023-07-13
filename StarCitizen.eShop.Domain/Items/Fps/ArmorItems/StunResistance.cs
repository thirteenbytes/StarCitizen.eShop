namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public record StunResistance
{
    private StunResistance(decimal value) =>
        Value = value;

    private StunResistance() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static StunResistance NotApplicable = new StunResistance { InUse = false };

    public static StunResistance Create(decimal? value)
    {
        if (value.HasValue)
        {

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{value}");
            }
            return new StunResistance(value.Value);
        }

        return NotApplicable;
    }
}

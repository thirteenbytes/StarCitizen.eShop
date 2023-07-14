namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public sealed record EnergyResistance
{
    private EnergyResistance(decimal value) =>
        Value = value;

    private EnergyResistance() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static EnergyResistance NotApplicable = new EnergyResistance { InUse = false };

    public static EnergyResistance Create(decimal? value)
    {
        if (value.HasValue)
        {


            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{value}");
            }
            return new EnergyResistance(value.Value);
        }

        return NotApplicable;
    }
}

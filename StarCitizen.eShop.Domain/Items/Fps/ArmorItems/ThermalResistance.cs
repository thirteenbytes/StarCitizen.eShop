namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public record ThermalResistance
{
    private ThermalResistance(decimal value) =>
        Value = value;

    private ThermalResistance() { }

    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static ThermalResistance NotApplicable = new ThermalResistance { InUse = false };

    public static ThermalResistance Create(decimal? value)
    {
        if (value.HasValue)
        {

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{value}");
            }

            return new ThermalResistance(value.Value);
        }

        return NotApplicable;
    }
}

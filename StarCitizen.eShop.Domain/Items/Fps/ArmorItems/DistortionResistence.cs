namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public sealed record DistortionResistence
{
    private DistortionResistence(decimal value) =>
        Value = value;

    private DistortionResistence() { }
    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static DistortionResistence NotApplicable = new DistortionResistence { InUse = false };

    public static DistortionResistence Create(decimal? value)
    {
        if(value.HasValue)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{value}");
            }

            return new DistortionResistence(value.Value);
        }

        return NotApplicable;
    }
}

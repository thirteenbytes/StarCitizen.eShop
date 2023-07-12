namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public record TemperatureRange
{
    private TemperatureRange(decimal minimumTemperature, decimal maximumTemperature)
    {
        MinimumTemperature = minimumTemperature;
        MaximumTemperature = maximumTemperature;
    }
    private TemperatureRange() { }  

    public decimal MinimumTemperature { get; init; }
    public decimal MaximumTemperature { get; init; }

    public bool InUse { get; init; } = true;

    public static TemperatureRange NotApplicable = new TemperatureRange { InUse = false };

    public static TemperatureRange Create(decimal minimumTemperature, decimal maximumTemperature)
    {
        if (minimumTemperature > maximumTemperature)
            throw new ArgumentOutOfRangeException($"Minimum cannot exceed Maximum values for {minimumTemperature} and {maximumTemperature}");

        return new TemperatureRange(minimumTemperature, maximumTemperature);
    }
}

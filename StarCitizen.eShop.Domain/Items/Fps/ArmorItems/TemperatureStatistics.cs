namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public sealed record TemperatureStatistics
{
    private TemperatureStatistics(decimal minimumTemperature, decimal maximumTemperature)
    {
        MinimumTemperature = minimumTemperature;
        MaximumTemperature = maximumTemperature;
    }
    private TemperatureStatistics() { }  

    public decimal MinimumTemperature { get; init; }
    public decimal MaximumTemperature { get; init; }

    public bool InUse { get; init; } = true;

    public static TemperatureStatistics NotApplicable = new TemperatureStatistics { InUse = false };

    public static TemperatureStatistics Create(decimal? minimumTemperature, decimal? maximumTemperature)
    {
        if(minimumTemperature.HasValue && maximumTemperature.HasValue)
        {
            if (minimumTemperature.Value > maximumTemperature.Value)
                throw new ArgumentOutOfRangeException($"Minimum cannot exceed Maximum values for {minimumTemperature} and {maximumTemperature}");

            return new TemperatureStatistics(minimumTemperature.Value, maximumTemperature.Value);
        }
        
        return NotApplicable;
    }
}

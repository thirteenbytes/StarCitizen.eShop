namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public sealed record BiochemicalResistance
{
    private BiochemicalResistance(decimal value) =>
        Value = value;

    private BiochemicalResistance() { } 
    public decimal Value { get; init; }
    public bool InUse { get; init; } = true;

    public static BiochemicalResistance NotApplicable = new BiochemicalResistance {  InUse = false };

    public static BiochemicalResistance Create(decimal value)
    {
        if (value < 0) throw new ArgumentOutOfRangeException($"{value}");        
                
        return new BiochemicalResistance(value);
    }



}

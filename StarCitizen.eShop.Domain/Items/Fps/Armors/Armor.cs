namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public class Armor : Item<ArmorId>
{
    public Armor(ArmorId id, string name, ArmorType type, DamageReduction damageReduction, TemperatureRange temperatureRange, Capacity capacity, Volume volume) 
        : base(id, name)
    {        
        Type = type;
        DamageReduction = damageReduction;
        TemperatureRange = temperatureRange;
        Capacity = capacity;
        Volume = volume;
    }
    
    public ArmorType Type { get; private set; }
    public DamageReduction DamageReduction { get; private set; }
    public TemperatureRange TemperatureRange { get; private set; }
    public Capacity Capacity { get; private set; }
    public Volume Volume { get; private set; }
    private Armor() 
        : base() { }

    public void Update(string name, ArmorType type, DamageReduction damageReduction, TemperatureRange temperatureRange, Capacity capacity, Volume volume)
    {
        Name = name;
        Type = type;
        DamageReduction = damageReduction;
        TemperatureRange = temperatureRange;
        Capacity = capacity;
        Volume = volume;
    }

}

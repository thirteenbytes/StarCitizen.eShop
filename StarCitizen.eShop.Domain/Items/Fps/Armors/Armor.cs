namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public class Armor
{
    public Armor(ArmorId id, string name, ArmorType type, DamageReduction damageReduction, TemperatureRange temperatureRange, Capacity capacity, Volume volume)
    {
        Id = id;
        Name = name;
        Type = type;
        DamageReduction = damageReduction;
        TemperatureRange = temperatureRange;
        Capacity = capacity;
        Volume = volume;
    }

    public ArmorId Id { get; set; }
    public string Name { get; set; }
    public ArmorType Type { get; set; }
    public DamageReduction DamageReduction { get; set; }
    public TemperatureRange TemperatureRange { get; set; }
    public Capacity Capacity { get; set; }
    public Volume Volume { get; set; }
    private Armor() { }

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

namespace StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

public class Armor : Item<ArmorId>
{
    
    public Armor(
        ArmorId id,
        string name,
        string manufacturer,
        ArmorType type, 
        DamageReduction damageReduction, 
        TemperatureStatistics temperatureStatistics, 
        Capacity capacity, 
        Volume volume, 
        BiochemicalResistance biochemicalResistance, 
        DistortionResistence distortionResistence, 
        EnergyResistance energyResistance, 
        PhysicalResistance physicalResistance, 
        StunResistance stunResistance, 
        ThermalResistance thermalResistance) : base(id, name, manufacturer) 
    {
        Type = type;
        DamageReduction = damageReduction;
        TemperatureRange = temperatureStatistics;
        Capacity = capacity;
        Volume = volume;
        BiochemicalResistance = biochemicalResistance;
        DistortionResistence = distortionResistence;
        EnergyResistance = energyResistance;
        PhysicalResistance = physicalResistance;
        StunResistance = stunResistance;
        ThermalResistance = thermalResistance;
    }

    public ArmorType Type { get; private set; }
    public DamageReduction DamageReduction { get; private set; }
    public TemperatureStatistics TemperatureRange { get; private set; }
    public Capacity Capacity { get; private set; }
    public Volume Volume { get; private set; }
    public BiochemicalResistance BiochemicalResistance { get; private set; }
    public DistortionResistence DistortionResistence { get; private set; }
    public EnergyResistance EnergyResistance { get; private set; }
    public PhysicalResistance PhysicalResistance { get; private set; }
    public StunResistance StunResistance { get; private set; }
    public ThermalResistance ThermalResistance { get; private set; }    

    private Armor() 
        : base() { }
       

    public void Update(
        ArmorType type,
        DamageReduction damageReduction,
        TemperatureStatistics temperatureRange,
        Capacity capacity,
        Volume volume,
        BiochemicalResistance biochemicalResistance,
        DistortionResistence distortionResistence,
        EnergyResistance energyResistance,
        PhysicalResistance physicalResistance,
        StunResistance stunResistance,
        ThermalResistance thermalResistance)
    {
        Type = type;
        DamageReduction = damageReduction;
        TemperatureRange = temperatureRange;
        Capacity = capacity;
        Volume = volume;
        BiochemicalResistance = biochemicalResistance;
        DistortionResistence = distortionResistence;
        EnergyResistance = energyResistance;
        PhysicalResistance = physicalResistance;
        StunResistance = stunResistance;
        ThermalResistance = thermalResistance;
    }



}

namespace StarCitizen.eShop.Domain.Satellites;

public class Satellite
{
    public Satellite(SatelliteId id, string name, string description, SatelliteType type/*, Satellite parent*/)
    {
        Id = id;
        Name = name;
        Description = description;
        Type = type;
        // Parent = parent;
    }

    private Satellite() { }

    public SatelliteId Id { get; private set; }
    public string Name { get; private set; } 
    public string Description { get; private set; } = string.Empty;
    public SatelliteType Type { get; private set; }
    // public Satellite Parent { get; private set; } = null!;

    public void Update(string name, string description, SatelliteType type)
    {
        Name = name;
        Description = description;
        Type = type;
    }



}

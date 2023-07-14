namespace StarCitizen.eShop.Domain.Satellites;

public sealed class Satellite
{
    public Satellite(SatelliteId id, string name, string description, SatelliteType type)
    {
        Id = id;
        Name = name;
        Description = description;
        Type = type;
    }

    public Satellite(SatelliteId id, string name, string description, SatelliteType type, SatelliteId parentId)
    {
        Id = id;
        Name = name;
        Description = description;
        Type = type;
        ParentId = parentId;
    }

    private Satellite() { }

    public SatelliteId Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public SatelliteType Type { get; private set; }
    public SatelliteId ParentId { get; private set; }

    public void Update(string name, string description, SatelliteType type)
    {
        Name = name;
        Description = description;
        Type = type;
    }

    public void Update(string name, string description, SatelliteType type, SatelliteId parentId)
    {
        Name = name;
        Description = description;
        Type = type;
        ParentId = parentId;
    }
}

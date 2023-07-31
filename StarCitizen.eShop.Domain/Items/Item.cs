using StarCitizen.eShop.Domain.Shared;

namespace StarCitizen.eShop.Domain.Items;

public abstract class Item
{
    protected Item() { }
    protected Item(Id id, string name, string manufacturer)
    {
        Id = id;
        Name = name;
        Manufacturer = manufacturer;
    }
    public Id Id { get; protected set; }
    public string Name { get; protected set; }
    public string Manufacturer { get; set; }
}

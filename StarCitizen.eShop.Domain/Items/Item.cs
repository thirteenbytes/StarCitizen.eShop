namespace StarCitizen.eShop.Domain.Items;

public abstract class Item<TId>
{
    protected Item() { }
    protected Item(TId id, string name, string manufacturer)
    {
        Id = id;
        Name = name;
        Manufacturer = manufacturer;
    }
    public TId Id { get; protected set; }
    public string Name { get; protected set; }
    public string Manufacturer { get; set; }
}

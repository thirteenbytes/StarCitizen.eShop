namespace StarCitizen.eShop.Domain.Items;

public abstract class Item<TId>
{
    protected Item() { }
    protected Item(TId id, string name)
    {
        Id = id;
        Name = name;
    }
    public TId Id { get; protected set; }
    public string Name { get; protected set; }
}

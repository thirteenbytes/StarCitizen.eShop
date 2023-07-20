using StarCitizen.eShop.Domain.Shared;

namespace StarCitizen.eShop.Domain.Facilities;

public sealed class Facility
{

    private Facility(FacilityId id, string name, FacilityType type, Location location)
    {
        Id = id;
        Name = name;
        Type = type;
        Location = location;
    }
    private Facility(FacilityId id, string name, string description, FacilityType type, Location location)
        : this(id, name, type, location)
    {
        Description = description;
    }

    private Facility(FacilityId id, string name, string description, FacilityType type, Location location, List<StockItem> inventory)
        : this(id, name, description, type, location)
    {
        Inventory = inventory;
    }

    private Facility() { }

    public FacilityId Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public FacilityType Type { get; private set; }
    public Location Location { get; private set; }
    public List<StockItem> Inventory { get; private set; }

    public static Facility Create(string name, string description, FacilityType type, Location location, List<StockItem> inventory)
    {
        var id = new FacilityId(Guid.NewGuid());
        if (string.IsNullOrEmpty(description) && inventory == null)
        {
            return new Facility(id, name, description, type, location);
        }


        return new Facility(id, name, description, type, location, inventory);
    }


    public void Update(FacilityId id, string name, string description, FacilityType type, Location location)
    {
        Id = id;
        Name = name;
        Type = type;
        Location = location;
    }

    public void UpdateInventory(List<StockItem> inventory) =>
        Inventory = inventory;

    public void AddStockItemToInventory(StockItem item)
    {
        if (Inventory is null)
        {
            Inventory = new List<StockItem>
            {
                item
            };
        }
        else
        {
            Inventory.Add(item);
        }
    }

    public void SubstractQuantityFromStockItemInInventory(object itemId, int quantityToSubtract)
    {
        var stockItem = Inventory.FirstOrDefault(x => x.Item.Id == itemId);
        if (stockItem != null)
        {
            stockItem.QuantityInStock.Subtract(quantityToSubtract);
        }
    }
}

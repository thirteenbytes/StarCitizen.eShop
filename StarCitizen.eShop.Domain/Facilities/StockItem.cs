using StarCitizen.eShop.Domain.Items;
using StarCitizen.eShop.Domain.Shared;

namespace StarCitizen.eShop.Domain.Facilities;

public sealed record StockItem
{
    public Item Item { get; set; }
    public Money CostPerItem { get; set; }
    public Quantity QuantityInStock { get; set; }    
}

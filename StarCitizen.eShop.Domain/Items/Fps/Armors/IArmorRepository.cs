namespace StarCitizen.eShop.Domain.Items.Fps.Armors;

public interface IArmorRepository
{
    Task<Armor> GetByIdAsync(ArmorId id);
    void Add(Armor armor);
    void Update(Armor armor);
    void Delete(Armor armor);
}

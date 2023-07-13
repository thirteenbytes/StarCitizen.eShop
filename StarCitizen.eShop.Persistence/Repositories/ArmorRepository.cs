using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Domain.Items.Fps.ArmorItems;

namespace StarCitizen.eShop.Persistence.Repositories;

internal sealed class ArmorRepository : IArmorRepository
{
    private readonly ApplicationDbContext context;

    public ArmorRepository(ApplicationDbContext context) =>
        this.context = context;

    public void Add(Armor armor) =>
        context.Armors.Add(armor);


    public void Delete(Armor armor) =>
        context.Armors.Remove(armor);


    public Task<Armor?> GetByIdAsync(ArmorId id) =>
        context.Armors.SingleOrDefaultAsync(x => x.Id == id);

    public void Update(Armor armor) =>
        context.Armors.Update(armor);

}

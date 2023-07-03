using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.Data;

public interface IApplicationDbContext
{
    DbSet<Satellite> Satellites { get; set; }

    DatabaseFacade Database { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

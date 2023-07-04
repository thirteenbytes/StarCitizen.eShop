using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Primitives;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext, IUnitOfWork
{
    private readonly IPublisher publisher;

    public ApplicationDbContext(DbContextOptions options, IPublisher publisher) : base(options) =>
        this.publisher = publisher;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    public DbSet<Satellite> Satellites { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var domainEvents = ChangeTracker.Entries<Entity>()
            .Select(e => e.Entity)
            .Where(e => e.GetDomainEvents().Any())
            .SelectMany(e => e.GetDomainEvents());

        var result = await base.SaveChangesAsync(cancellationToken);

        foreach (var domainEvent in domainEvents)
        {
            await publisher.Publish(domainEvent, cancellationToken);
        }

        return result;

    }
}

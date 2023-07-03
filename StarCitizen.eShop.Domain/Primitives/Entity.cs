namespace StarCitizen.eShop.Domain.Primitives;

public abstract class Entity
{
    private readonly List<DomainEvent> domainEvents = new();

    public ICollection<DomainEvent> GetDomainEvents =>
        domainEvents;

    protected void Raise(DomainEvent domainEvent) =>
        domainEvents.Add(domainEvent);
}

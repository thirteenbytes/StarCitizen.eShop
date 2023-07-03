using MediatR;

namespace StarCitizen.eShop.Domain.Primitives;

public record DomainEvent(Guid Id) : INotification;

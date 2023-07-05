using MediatR;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Update;

internal sealed class UpdateSatelliteCommandHandler : IRequestHandler<UpdateSatelliteCommand>
{
    private readonly ISatelliteRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public UpdateSatelliteCommandHandler(ISatelliteRepository repository, IUnitOfWork unitOfWork)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public async Task Handle(UpdateSatelliteCommand request, CancellationToken cancellationToken)
    {
        var satellite = await repository.GetByIdAsync(request.SatelliteId);

        if (satellite is null)
        {
            throw new SatelliteNotFoundExpection(request.SatelliteId);
        }

        satellite.Update(request.Name, request.Description, SatelliteType.Create(request.Type), request.ParentId);
        repository.Update(satellite);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

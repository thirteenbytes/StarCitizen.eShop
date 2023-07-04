using MediatR;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Delete;

internal class DeleteSatelliteCommandHandler : IRequestHandler<DeleteSatelliteCommand>
{
    private readonly ISatelliteRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public DeleteSatelliteCommandHandler(ISatelliteRepository repository, IUnitOfWork unitOfWork)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public async Task Handle(DeleteSatelliteCommand request, CancellationToken cancellationToken)
    {
        var satellite = await repository.GetByIdAsync(request.SatelliteId);

        if (satellite is null)
        {
            throw new SatelliteNotFoundExpection(request.SatelliteId);
        }

        repository.Delete(satellite);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

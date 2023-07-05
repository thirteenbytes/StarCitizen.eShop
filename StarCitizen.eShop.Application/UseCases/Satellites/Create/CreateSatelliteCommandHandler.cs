using MediatR;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Create;

internal class CreateSatelliteCommandHandler : IRequestHandler<CreateSatelliteCommand>
{
    private readonly ISatelliteRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public CreateSatelliteCommandHandler(ISatelliteRepository repository, IUnitOfWork unitOfWork)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public async Task Handle(CreateSatelliteCommand request, CancellationToken cancellationToken)
    {

        Satellite satellite = null!;
        
        if (request.parentId is null)
        {
            satellite = new Satellite(
                new SatelliteId(Guid.NewGuid()),
                request.Name,
                request.Description,
                SatelliteType.Create(request.Type));

            
        }
        else
        {
            var parentSatellite = await repository.GetByIdAsync(request.parentId);
            if (parentSatellite is null)
            {
                throw new SatelliteNotFoundExpection(request.parentId);
            }

            satellite = new Satellite(
                new SatelliteId(Guid.NewGuid()),
                request.Name,
                request.Description,
                SatelliteType.Create(request.Type), 
                parentSatellite.Id);

            repository.Add(satellite);

        }
        repository.Add(satellite);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

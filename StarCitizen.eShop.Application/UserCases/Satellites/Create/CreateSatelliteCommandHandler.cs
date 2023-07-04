using MediatR;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Satellites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCitizen.eShop.Application.UserCases.Satellites.Create;

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
        var satellite = new Satellite(
            new SatelliteId(Guid.NewGuid()), 
            request.Name, 
            request.Description, 
            SatelliteType.Create(request.Type));

        repository.Add(satellite);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

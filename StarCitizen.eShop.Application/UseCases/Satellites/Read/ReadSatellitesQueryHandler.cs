using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Read;

internal sealed class ReadSatellitesQueryHandler : IRequestHandler<ReadSatellitesQuery, IEnumerable<SatelliteResponse>>
{
    private readonly IApplicationDbContext context;

    public ReadSatellitesQueryHandler(IApplicationDbContext context) =>
        this.context = context;

    public async Task<IEnumerable<SatelliteResponse>> Handle(ReadSatellitesQuery request, CancellationToken cancellationToken) =>    
         await context.Satellites
        .Select(s => new SatelliteResponse(
                s.Id.Value,
                s.Name,
                s.Description,
                s.Type.Value.ToString()))       
        .ToListAsync(cancellationToken);
    
}

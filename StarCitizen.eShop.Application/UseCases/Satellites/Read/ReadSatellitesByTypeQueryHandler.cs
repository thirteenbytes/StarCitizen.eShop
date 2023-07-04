using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Read;

internal sealed class ReadSatellitesByTypeQueryHandler : IRequestHandler<ReadSatellitesByTypeQuery, IEnumerable<SatelliteResponse>>
{
    private readonly IApplicationDbContext context;

    public ReadSatellitesByTypeQueryHandler(IApplicationDbContext context) =>
        this.context = context;

    public async Task<IEnumerable<SatelliteResponse>> Handle(ReadSatellitesByTypeQuery request, CancellationToken cancellationToken)
    {
        var satellites = await context
            .Satellites
            .Where(s => s.Type == request.SatelliteType)
            .Select(s => new SatelliteResponse(
                s.Id.Value,
                s.Name,
                s.Description,
                s.Type.Value.ToString())).ToListAsync();

        return satellites;
    }
}

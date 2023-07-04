using MediatR;
using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Application.Data;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Application.UseCases.Satellites.Read;

internal sealed class ReadSatelliteQueryHandler : IRequestHandler<ReadSatelliteQuery, SatelliteResponse>
{
    private readonly IApplicationDbContext context;

    public ReadSatelliteQueryHandler(IApplicationDbContext context) =>
        this.context = context;

    public async Task<SatelliteResponse> Handle(ReadSatelliteQuery request, CancellationToken cancellationToken)
    {
        var satellite = await context
            .Satellites
            .Where(s => s.Id == request.SatelliteId)
            .Select(s => new SatelliteResponse(
                s.Id.Value,
                s.Name,
                s.Description,
                s.Type.Value.ToString()))
            .FirstOrDefaultAsync(cancellationToken);

        if (satellite is null)
        {
            throw new SatelliteNotFoundExpection(request.SatelliteId);
        }

        return satellite;
    }
}

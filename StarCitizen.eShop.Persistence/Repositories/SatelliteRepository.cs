using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Domain.Satellites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCitizen.eShop.Persistence.Repositories;

internal sealed class SatelliteRepository : ISatelliteRepository
{
    private readonly ApplicationDbContext context;

    public SatelliteRepository(ApplicationDbContext context) =>
        this.context = context;
    

    public Task<Satellite?> GetByIdAsync(SatelliteId id) =>
        context.Satellites.SingleOrDefaultAsync(s=>s.Id == id);
    
        
    
}

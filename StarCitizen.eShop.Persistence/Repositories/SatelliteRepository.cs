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

    public void Add(Satellite satellite) =>
        context.Satellites.Add(satellite);
        
    public void Delete(Satellite satellite) =>
        context.Satellites.Remove(satellite);
    
    public Task<Satellite?> GetByIdAsync(SatelliteId id) =>
        context.Satellites.SingleOrDefaultAsync(s=>s.Id == id);

    public void Update(Satellite satellite) =>
        context.Satellites.Update(satellite);
}

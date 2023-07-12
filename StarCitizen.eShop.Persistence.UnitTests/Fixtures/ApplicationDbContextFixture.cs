using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using StarCitizen.eShop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCitizen.eShop.Persistence.UnitTests.Fixtures;

public sealed class ApplicationDbContextFixture : IDisposable
{
    public ApplicationDbContext Context { get; private set; }
    
    public ApplicationDbContextFixture()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        Context = new ApplicationDbContext(options);
    }    
   
    public void Dispose()
    {
        Context.Dispose();
    }
}

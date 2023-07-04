using Microsoft.EntityFrameworkCore;
using StarCitizen.eShop.Persistence;

namespace StarCitizen.eShop.WebApi.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this WebApplication application)
    {
        using var scope = application.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        dbContext.Database.Migrate();
    }
}

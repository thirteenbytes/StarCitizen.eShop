using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Persistence.Configurations;

internal class SatelliteConfiguration : IEntityTypeConfiguration<Satellite>
{
    public void Configure(EntityTypeBuilder<Satellite> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(satelliteId => satelliteId.Value, value => new SatelliteId(value));

        builder.Property(x => x.Name).HasMaxLength(100);
        builder.HasIndex(x => x.Name).IsUnique();
        builder.Property(x => x.Description).HasMaxLength(255);

        builder.Property(x => 
            x.SatelliteType)
            .HasConversion(satelliteType => 
                satelliteType.Value, value => new SatelliteType(value))
            .HasMaxLength(100);

    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCitizen.eShop.Domain.Satellites;

namespace StarCitizen.eShop.Persistence.Configurations;

internal class SatelliteConfiguration : IEntityTypeConfiguration<Satellite>
{
    public void Configure(EntityTypeBuilder<Satellite> builder)
    {
        builder.ToTable("Satellite");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(satelliteId => satelliteId.Value, value => new SatelliteId(value));

        builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
        builder.HasIndex(x => x.Name).IsUnique();

        builder.Property(x => x.Description).HasMaxLength(255);

        builder.Property(x => x.Type).HasConversion(st => st.Value.ToString(),
            value => SatelliteType.Create(value)).HasMaxLength(150).IsRequired();

        builder.Property(x => x.ParentId).HasConversion(parentId => parentId.Value, value => new SatelliteId(value));        
    }
}

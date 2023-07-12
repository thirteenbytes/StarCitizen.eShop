using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StarCitizen.eShop.Domain.Items.Fps.Armors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCitizen.eShop.Persistence.Configurations;

internal sealed class ArmorConfiguration : IEntityTypeConfiguration<Armor>
{
    public void Configure(EntityTypeBuilder<Armor> builder)
    {
        builder.ToTable("Armor");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(a=>a.Value, v => new ArmorId(v));

        builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
        builder.HasIndex(x => x.Name).IsUnique();

        builder.Property(x => x.Type).HasConversion(t => t.Value.ToString(),
            v => ArmorType.Create(v)).HasMaxLength(150).IsRequired();

        builder.Property(x=>x.DamageReduction).HasConversion(d=>d.Value, v=>DamageReduction.Create(v));
        builder.Property(x => x.Capacity).HasConversion(c => c.Value, v => Capacity.Create(v));
        builder.Property(x => x.Volume).HasConversion(v => v.Value, v => Volume.Create(v));
        builder.OwnsOne(x => x.TemperatureRange).Property(t => t.MinimumTemperature).HasColumnName("MinimumTemperature");
        builder.OwnsOne(x => x.TemperatureRange).Property(t => t.MaximumTemperature).HasColumnName("MaximumTemperature");
        builder.OwnsOne(x => x.TemperatureRange).Ignore(t => t.InUse);

    }
}

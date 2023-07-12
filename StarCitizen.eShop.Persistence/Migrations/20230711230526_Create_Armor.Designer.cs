﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarCitizen.eShop.Persistence;

#nullable disable

namespace StarCitizen.eShop.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230711230526_Create_Armor")]
    partial class Create_Armor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StarCitizen.eShop.Domain.Items.Fps.Armors.Armor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Capacity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DamageReduction")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal?>("Volume")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Armor", (string)null);
                });

            modelBuilder.Entity("StarCitizen.eShop.Domain.Satellites.Satellite", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Satellite", (string)null);
                });

            modelBuilder.Entity("StarCitizen.eShop.Domain.Items.Fps.Armors.Armor", b =>
                {
                    b.OwnsOne("StarCitizen.eShop.Domain.Items.Fps.Armors.TemperatureRange", "TemperatureRange", b1 =>
                        {
                            b1.Property<Guid>("ArmorId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("MaximumTemperature")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("MaximumTemperature");

                            b1.Property<decimal>("MinimumTemperature")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("MinimumTemperature");

                            b1.HasKey("ArmorId");

                            b1.ToTable("Armor");

                            b1.WithOwner()
                                .HasForeignKey("ArmorId");
                        });

                    b.Navigation("TemperatureRange");
                });
#pragma warning restore 612, 618
        }
    }
}

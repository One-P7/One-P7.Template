﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using ThreeLayer.Database.AdventureWorks.Models;

namespace ThreeLayer.Database.AdventureWorks.Models.Configurations
{
    public partial class CountryRegionConfiguration : IEntityTypeConfiguration<CountryRegion>
    {
        public void Configure(EntityTypeBuilder<CountryRegion> entity)
        {
            entity.HasKey(e => e.CountryRegionCode).HasName("PK_CountryRegion_CountryRegionCode");

            entity.ToTable("CountryRegion", "Person", tb => tb.HasComment("Lookup table containing the ISO standard codes for countries and regions."));

            entity.HasIndex(e => e.Name, "AK_CountryRegion_Name").IsUnique();

            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(3)
                .HasComment("ISO standard code for countries and regions.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Country or region name.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CountryRegion> entity);
    }
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using ThreeLayer.Database.AdventureWorks.Models;

namespace ThreeLayer.Database.AdventureWorks.Models.Configurations
{
    public partial class ScrapReasonConfiguration : IEntityTypeConfiguration<ScrapReason>
    {
        public void Configure(EntityTypeBuilder<ScrapReason> entity)
        {
            entity.HasKey(e => e.ScrapReasonId).HasName("PK_ScrapReason_ScrapReasonID");

            entity.ToTable("ScrapReason", "Production", tb => tb.HasComment("Manufacturing failure reasons lookup table."));

            entity.HasIndex(e => e.Name, "AK_ScrapReason_Name").IsUnique();

            entity.Property(e => e.ScrapReasonId)
                .HasComment("Primary key for ScrapReason records.")
                .HasColumnName("ScrapReasonID");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Failure description.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ScrapReason> entity);
    }
}

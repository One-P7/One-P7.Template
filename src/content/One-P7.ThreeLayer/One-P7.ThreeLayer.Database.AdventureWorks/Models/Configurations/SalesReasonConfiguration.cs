﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using ThreeLayer.Database.AdventureWorks.Models;

namespace ThreeLayer.Database.AdventureWorks.Models.Configurations
{
    public partial class SalesReasonConfiguration : IEntityTypeConfiguration<SalesReason>
    {
        public void Configure(EntityTypeBuilder<SalesReason> entity)
        {
            entity.HasKey(e => e.SalesReasonId).HasName("PK_SalesReason_SalesReasonID");

            entity.ToTable("SalesReason", "Sales", tb => tb.HasComment("Lookup table of customer purchase reasons."));

            entity.Property(e => e.SalesReasonId)
                .HasComment("Primary key for SalesReason records.")
                .HasColumnName("SalesReasonID");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Sales reason description.");
            entity.Property(e => e.ReasonType)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Category the sales reason belongs to.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SalesReason> entity);
    }
}

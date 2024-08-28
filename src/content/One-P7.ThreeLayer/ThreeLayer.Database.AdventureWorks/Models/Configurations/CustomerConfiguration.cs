﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using ThreeLayer.Database.AdventureWorks.Models;

namespace ThreeLayer.Database.AdventureWorks.Models.Configurations
{
    public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Customer_CustomerID");

            entity.ToTable("Customer", "Sales", tb => tb.HasComment("Current customer information. Also see the Person and Store tables."));

            entity.HasIndex(e => e.AccountNumber, "AK_Customer_AccountNumber").IsUnique();

            entity.HasIndex(e => e.Rowguid, "AK_Customer_rowguid").IsUnique();

            entity.HasIndex(e => e.TerritoryId, "IX_Customer_TerritoryID");

            entity.Property(e => e.CustomerId)
                .HasComment("Primary key.")
                .HasColumnName("CustomerID");
            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComputedColumnSql("(isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),''))", false)
                .HasComment("Unique number identifying the customer assigned by the accounting system.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");
            entity.Property(e => e.PersonId)
                .HasComment("Foreign key to Person.BusinessEntityID")
                .HasColumnName("PersonID");
            entity.Property(e => e.Rowguid)
                .HasDefaultValueSql("(newid())")
                .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")
                .HasColumnName("rowguid");
            entity.Property(e => e.StoreId)
                .HasComment("Foreign key to Store.BusinessEntityID")
                .HasColumnName("StoreID");
            entity.Property(e => e.TerritoryId)
                .HasComment("ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.")
                .HasColumnName("TerritoryID");

            entity.HasOne(d => d.Person).WithMany(p => p.Customers).HasForeignKey(d => d.PersonId);

            entity.HasOne(d => d.Store).WithMany(p => p.Customers).HasForeignKey(d => d.StoreId);

            entity.HasOne(d => d.Territory).WithMany(p => p.Customers).HasForeignKey(d => d.TerritoryId);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Customer> entity);
    }
}

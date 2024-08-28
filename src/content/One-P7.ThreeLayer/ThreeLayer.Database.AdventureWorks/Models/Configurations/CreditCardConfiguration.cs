﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using ThreeLayer.Database.AdventureWorks.Models;

namespace ThreeLayer.Database.AdventureWorks.Models.Configurations
{
    public partial class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> entity)
        {
            entity.HasKey(e => e.CreditCardId).HasName("PK_CreditCard_CreditCardID");

            entity.ToTable("CreditCard", "Sales", tb => tb.HasComment("Customer credit card information."));

            entity.HasIndex(e => e.CardNumber, "AK_CreditCard_CardNumber").IsUnique();

            entity.Property(e => e.CreditCardId)
                .HasComment("Primary key for CreditCard records.")
                .HasColumnName("CreditCardID");
            entity.Property(e => e.CardNumber)
                .IsRequired()
                .HasMaxLength(25)
                .HasComment("Credit card number.");
            entity.Property(e => e.CardType)
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Credit card name.");
            entity.Property(e => e.ExpMonth).HasComment("Credit card expiration month.");
            entity.Property(e => e.ExpYear).HasComment("Credit card expiration year.");
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Date and time the record was last updated.")
                .HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CreditCard> entity);
    }
}

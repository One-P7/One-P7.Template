using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace One_P7.ThreeLayer.Database.SQLiteAdventureWorks.Models.Configurations;
public partial class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory");

        builder.HasKey(pc => pc.ProductCategoryId);

        builder.Property(pc => pc.ProductCategoryId)
               .HasColumnName("ProductCategoryID");

        builder.Property(pc => pc.ParentProductCategoryId)
               .HasColumnName("ParentProductCategoryID");

        builder.Property(pc => pc.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(pc => pc.RowGuid)
               .HasColumnName("rowguid")
               .IsRequired();

        builder.Property(pc => pc.ModifiedDate)
               .IsRequired();

        builder.HasOne(pc => pc.ParentCategory)
               .WithMany(pc => pc.ChildCategories)
               .HasForeignKey(pc => pc.ParentProductCategoryId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}

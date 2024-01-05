using eShopSolution.Data.Constans;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product> 
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(TableName.Product);

        builder.HasKey(e => e.Id);
        builder.HasOne(e => e.Category)
            .WithMany(e => e.Products);

        builder.Property(e => e.Price).IsRequired();
        builder.Property(e => e.Stock).IsRequired().HasDefaultValue(0);
        builder.Property(e => e.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
        builder.Property(e => e.SeoAlias).IsRequired();
        
    }
}
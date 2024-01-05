using eShopSolution.Data.Constans;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(TableName.Category);
        
        builder.HasKey(e => e.Id);
        builder.Property(e => e.CategoryName).IsRequired();
    }
}
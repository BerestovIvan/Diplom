using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasKey(subcategory => subcategory.Id);
            builder.HasIndex(subcategory => subcategory.Id).IsUnique();
            builder.Property(subcategory => subcategory.CategoryId).IsRequired();

            builder.HasMany(c => c.Products).
            WithOne(e => e.Subcategory)
            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
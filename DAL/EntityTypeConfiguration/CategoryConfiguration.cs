using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(category => category.Id);
            builder.HasIndex(category => category.Id).IsUnique();
            builder.HasIndex(category => category.Name).IsUnique();
            builder.Property(category => category.Name).HasMaxLength(60).IsRequired();

            builder.HasMany(c => c.Subcategories).
            WithOne(e => e.Category)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

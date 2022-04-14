using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(brand => brand.Id);
            builder.HasIndex(brand => brand.Id).IsUnique();
            builder.HasIndex(brand => brand.Name).IsUnique();
            builder.Property(brand => brand.Name).HasMaxLength(60).IsRequired();
        }
    }
}

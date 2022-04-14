using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.HasIndex(product => product.Id).IsUnique();
            builder.Property(product => product.Description).HasMaxLength(1500).IsRequired();
            builder.Property(product => product.Name).HasMaxLength(60).IsRequired();
            builder.Property(product => product.Price).IsRequired();
            builder.Property(product => product.Amount).IsRequired();
            builder.Property(product => product.CreatorId).IsRequired();
            builder.Property(product => product.GenderId).IsRequired();
            builder.Property(product => product.SubcategoryId).IsRequired();
            builder.Property(product => product.BrandId).IsRequired();

            builder.HasMany(c => c.Comments).
            WithOne(e => e.Product)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(c => c.OrderProducts).
            WithOne(e => e.Product)
            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}

using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProducts>
    {
        public void Configure(EntityTypeBuilder<OrderProducts> builder)
        {
            builder.HasKey(orderProducts => orderProducts.Id);
            builder.HasIndex(orderProducts => orderProducts.Id).IsUnique();
            builder.Property(orderProducts => orderProducts.OrderId).IsRequired();
            builder.Property(orderProducts => orderProducts.ProductId).IsRequired();
            builder.Property(orderProducts => orderProducts.ProductAmount).IsRequired();
        }
    }
}

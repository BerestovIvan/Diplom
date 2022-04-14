using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(order => order.Id);
            builder.HasIndex(order => order.Id).IsUnique();
            builder.Property(order => order.OrderTime).IsRequired();
            builder.Property(order => order.ApplicationUserId).IsRequired();

            builder.HasMany(c => c.OrderProducts).
            WithOne(e => e.Order)
            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}

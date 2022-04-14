using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityTypeConfiguration
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(gender => gender.Id);
            builder.HasIndex(gender => gender.Id).IsUnique();
            builder.HasIndex(gender => gender.Name).IsUnique();
            builder.Property(gender => gender.Name).HasMaxLength(60).IsRequired();
        }
    }
}

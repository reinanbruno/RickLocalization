using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;

namespace RickLocalization.Infrastructure.Context.Configurations
{
    public static class DimensionConfiguration
    {
        public static void ConfigureDimension(this ModelBuilder builder)
        {
            builder
               .Entity<Dimension>()
               .HasKey(c => c.Id);

            builder.Entity<Dimension>()
                   .Property(c => c.Id)
                   .HasColumnName("id");

            builder
               .Entity<Dimension>()
               .Property(c => c.Name)
               .HasColumnName("name")
               .IsRequired()
               .HasMaxLength(100);

            builder
                .Entity<Dimension>()
                .HasIndex(x => x.Name).IsUnique();

        }
    }
}

using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;

namespace RickLocalization.Infrastructure.Context.Configurations
{
    public static class MortyConfiguration
    {
        public static void ConfigureMorty(this ModelBuilder builder)
        {
            builder
               .Entity<Morty>()
               .HasKey(c => c.Id);

            builder.Entity<Morty>()
                   .Property(c => c.Id)
                   .HasColumnName("id");

            builder
               .Entity<Morty>()
               .Property(c => c.Name)
               .HasColumnName("name")
               .IsRequired()
               .HasMaxLength(100);

            builder
                .Entity<Morty>()
                .HasIndex(x => x.Name).IsUnique();

            builder
               .Entity<Morty>()
               .Property(c => c.UrlImage)
               .HasColumnName("url_image")
               .IsRequired()
               .HasMaxLength(200);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;

namespace RickLocalization.Infrastructure.Context.Configurations
{
    public static class RickConfiguration
    {
        public static void ConfigureRick(this ModelBuilder builder)
        {
            builder
               .Entity<Rick>()
               .HasKey(c => c.Id);

            builder
              .Entity<Rick>()
              .Property(c => c.Id)
              .HasColumnName("id");

            builder
               .Entity<Rick>()
               .Property(c => c.IdMorty)
               .HasColumnName("id_morty")
               .IsRequired();

            builder
                .Entity<Rick>()
                .HasIndex(x => x.IdMorty).IsUnique();

            builder
               .Entity<Rick>()
               .Property(c => c.IdDimensionOrigin)
               .HasColumnName("id_dimension_origin")
               .IsRequired();

            builder
                .Entity<Rick>()
                .HasIndex(x => x.IdDimensionOrigin).IsUnique();

            builder
               .Entity<Rick>()
               .Property(c => c.Name)
               .HasColumnName("name")
               .HasMaxLength(100)
               .IsRequired();

            builder
                .Entity<Rick>()
                .HasIndex(x => x.Name).IsUnique();

            builder
               .Entity<Rick>()
               .Property(c => c.Description)
               .HasColumnName("description")
               .HasMaxLength(500);

            builder
               .Entity<Rick>()
               .Property(c => c.UrlImage)
               .HasColumnName("url_image")
               .IsRequired()
               .HasMaxLength(200);

            builder
               .Entity<Rick>()
               .Property(c => c.Url)
               .HasColumnName("url")
               .IsRequired()
               .HasMaxLength(200);

            builder
                .Entity<Rick>()
                .HasIndex(x => x.Url).IsUnique();

            builder
             .Entity<Rick>()
             .Property(c => c.RegistrationDate)
             .HasColumnName("registration_date")
             .IsRequired();

            builder
                .Entity<Rick>()
                .HasOne(o => o.Morty)
                .WithMany(o => o.Ricks)
                .HasForeignKey(o => o.IdMorty)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Rick>()
                .HasOne(o => o.DimensionOrigin)
                .WithMany(p => p.Ricks)
                .HasForeignKey(o => o.IdDimensionOrigin)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;

namespace RickLocalization.Infrastructure.Context.Configurations
{
    public static class DimensionTravelledConfiguration
    {
        public static void ConfigureHistoryDimension(this ModelBuilder builder)
        {
            builder
               .Entity<DimensionTravelled>()
               .HasKey(c => c.Id);

            builder.Entity<DimensionTravelled>()
                   .Property(c => c.Id)
                   .HasColumnName("id");

            builder
               .Entity<DimensionTravelled>()
               .Property(c => c.IdDimensionBefore)
               .HasColumnName("id_dimension_before");

            builder
               .Entity<DimensionTravelled>()
               .Property(c => c.IdDimensionCurrent)
               .HasColumnName("id_dimension_current")
               .IsRequired();

            builder
               .Entity<DimensionTravelled>()
               .Property(c => c.IdRick)
               .HasColumnName("id_rick")
               .IsRequired();

            builder
              .Entity<DimensionTravelled>()
              .Property(c => c.RegistrationDate)
              .HasColumnName("registration_date")
              .IsRequired();

            builder
                .Entity<DimensionTravelled>()
                .HasOne(o => o.Rick)
                .WithMany(o => o.DimensionsTravelled)
                .HasForeignKey(o => o.IdRick)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<DimensionTravelled>()
                .HasOne(o => o.DimensionBefore)
                .WithMany(o => o.DimensionsTravelledBefore)
                .HasForeignKey(o => o.IdDimensionBefore)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<DimensionTravelled>()
                .HasOne(o => o.DimensionCurrent)
                .WithMany(o => o.DimensionsTravelledCurrent)
                .HasForeignKey(o => o.IdDimensionCurrent)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}

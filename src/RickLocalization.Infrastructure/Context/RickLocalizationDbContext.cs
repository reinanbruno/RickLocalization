using Microsoft.EntityFrameworkCore;
using RickLocalization.Core.Entities;
using RickLocalization.Infrastructure.Context.Configurations;

namespace RickLocalization.Infrastructure.Context
{
    public class RickLocalizationDbContext : DbContext
    {
        public RickLocalizationDbContext(DbContextOptions<RickLocalizationDbContext> options) : base(options)
        {
        }

        public DbSet<Rick> Ricks { get; set; }
        public DbSet<Morty> Morties { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<DimensionTravelled> DimensionsTravelled { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RickLocalizationDbContext).Assembly).ConfigureDimension();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RickLocalizationDbContext).Assembly).ConfigureMorty();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RickLocalizationDbContext).Assembly).ConfigureRick();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RickLocalizationDbContext).Assembly).ConfigureHistoryDimension();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RickLocalizationDbContext).Assembly).Seed();
        }
    }
}

using AutoService.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Data
{
    class GarageDbContext : DbContext
    {
        public GarageDbContext(DbContextOptions<GarageDbContext> options) : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Mechanic> Mechanics { get; set; } = null!;
        public DbSet<ServiceRecord> ServiceRecords { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Unique constraints
            modelBuilder.Entity<Car>()
                .HasIndex(c => c.LicensePlate)
                .IsUnique();

            modelBuilder.Entity<Car>()
                .HasIndex(c => c.VIN)
                .IsUnique();

            // ServiceRecord ↔ Car
            modelBuilder.Entity<ServiceRecord>()
                .HasOne(sr => sr.Car)
                .WithMany(c => c.ServiceRecords)
                .HasForeignKey(sr => sr.CarId);

            // ServiceRecord ↔ Mechanic
            modelBuilder.Entity<ServiceRecord>()
                .HasOne(sr => sr.Mechanic)
                .WithMany(m => m.ServiceRecords)
                .HasForeignKey(sr => sr.MechanicId);
        }
    }
}

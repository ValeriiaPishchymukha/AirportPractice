using Airport.DAL.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext(DbContextOptions<AirportDbContext> options)
            : base(options)
        {
        }

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<AircraftType> AircraftTypes { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<PilotAircraft> PilotAircrafts { get; set; }
        public DbSet<AirportEntity> Airports { get; set; }
        public DbSet<FlightDestination> FlightDestinations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PilotAircraft>()
                .HasKey(pa => new { pa.PilotId, pa.AircraftId });

            modelBuilder.Entity<PilotAircraft>()
                .HasOne(pa => pa.Pilot)
                .WithMany(p => p.PilotAircrafts)
                .HasForeignKey(pa => pa.PilotId);

            modelBuilder.Entity<PilotAircraft>()
                .HasOne(pa => pa.Aircraft)
                .WithMany(a => a.PilotAircrafts)
                .HasForeignKey(pa => pa.AircraftId);

            modelBuilder.Entity<FlightDestination>()
                .Property(fd => fd.TicketPrice)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }

    }
}

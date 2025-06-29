using Airport.DAL.EF.Entities;
using Airport.DAL.EF.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Repositories
{
    public class FlightDestinationRepository : GenericRepository<FlightDestination>, IFlightDestinationRepository
    {
        public FlightDestinationRepository(AirportDbContext context) : base(context) { 
        }

        public async Task<List<FlightDestination>> GetFlightsByPassengerAsync(int passengerId)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.PassengerId == passengerId)
                .ToListAsync();
        }

        public async Task<List<FlightDestination>> GetUpcomingFlightsAsync(DateTime afterDate)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.Departure > afterDate)
                .ToListAsync();
        }

        public async Task<List<FlightDestination>> GetFlightsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.TicketPrice >= minPrice && fd.TicketPrice <= maxPrice)
                .ToListAsync();
        }

        public async Task<List<FlightDestination>> GetFlightsByAirportAsync(int airportId)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.AirportId == airportId)
                .ToListAsync();
        }
    }
}

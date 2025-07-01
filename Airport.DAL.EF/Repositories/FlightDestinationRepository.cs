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

        public override async Task<FlightDestination> GetByIDAsync(int id)
        {
            return await _context.Set<FlightDestination>()
                .Include(fd => fd.Airport)
                .Include(fd => fd.Aircraft)
                .Include(fd => fd.Passenger)
                .FirstOrDefaultAsync(fd => fd.Id == id);
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

        public override void Update(FlightDestination entity)
        {
            if (entity.Airport != null)
            {
                _context.Entry(entity.Airport).State = EntityState.Modified;
            }

            if (entity.Aircraft != null)
            {
                _context.Entry(entity.Aircraft).State = EntityState.Modified;
            }

            if (entity.Passenger != null)
            {
                _context.Entry(entity.Passenger).State = EntityState.Modified;
            }

            _context.Set<FlightDestination>().Update(entity);
        }
    }
}

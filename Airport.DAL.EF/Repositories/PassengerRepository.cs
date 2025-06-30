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
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(AirportDbContext context) : base(context)
        {
        }

        public async Task<Passenger> GetByEmailAsync(string email)
        {
            return await _context.Passengers.FirstOrDefaultAsync(p => p.Email == email);
        }

        public async Task<List<Passenger>> SearchByNameAsync(string partialName)
        {
            return await _context.Passengers
                .Where(p => p.FullName.Contains(partialName))
                .ToListAsync();
        }

        public async Task<List<(string AirportName, string Country)>> GetDestinationsByPassengerNameAsync(string fullName)
        {
            var passenger = await _context.Passengers
                .Include(p => p.FlightDestinations)
                .ThenInclude(fd => fd.Airport)
                .FirstOrDefaultAsync(p => p.FullName == fullName);

            if (passenger == null || passenger.FlightDestinations == null)
                return new List<(string, string)>();

            return passenger.FlightDestinations
                .Select(fd => (fd.Airport.Name, fd.Airport.Country))
                .ToList();
        }
    }
}

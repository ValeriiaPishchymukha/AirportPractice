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
    }
}

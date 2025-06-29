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
    public class PilotRepository : GenericRepository<Pilot>, IPilotRepository
    {
        public PilotRepository(AirportDbContext context) : base(context) { }

        public async Task<List<Pilot>> GetPilotsWithRatingAboveAsync(double minRating)
        {
            return await _dbSet.Where(p => p.Rating > minRating)
                .ToListAsync();
        }

        public async Task<List<Pilot>> GetPilotsByAgeRangeAsync(int minAge, int maxAge)
        {
            return await _dbSet.Where(p => p.Age >= minAge && p.Age <= maxAge)
                .ToListAsync();
        }

        public async Task<Pilot> GetPilotByFullNameAsync(string firstName, string lastName)
        {
            return await _dbSet.FirstOrDefaultAsync(p => p.FirstName == firstName && p.LastName == lastName);
        }

    }
}

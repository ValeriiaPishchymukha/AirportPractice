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
    public class AirportEntityRepository : GenericRepository<AirportEntity>, IAirportEntityRepository
    {
        public AirportEntityRepository(AirportDbContext context) : base(context)
        {
        }
        public async Task<List<AirportEntity>> GetAirportsByCountryAsync(string country)
        {
            return await _context.Airports
                .Where(a => a.Country == country)
                .ToListAsync();
        }
    }
}

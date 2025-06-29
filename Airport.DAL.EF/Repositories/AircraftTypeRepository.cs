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
    public class AircraftTypeRepository : GenericRepository<AircraftType>, IAircraftTypeRepository
    {
        public AircraftTypeRepository(AirportDbContext context) : base(context)
        {
        }
        public async Task<List<AircraftType>> GetTypesWithAircraftsAsync()
        {
            return await _context.AircraftTypes
                .Where(t => t.Aircrafts.Any())
                .ToListAsync();
        }
    }
    
}

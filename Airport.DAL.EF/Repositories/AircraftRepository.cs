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
    public class AircraftRepository : GenericRepository<Aircraft>, IAircraftRepository
    {
        public AircraftRepository(AirportDbContext context) : base(context)
        {
        }

        public async Task<List<Aircraft>> GetByManufacturerAsync(string manufacturer)
        {
            return await _context.Aircrafts
                .Where(a => a.Manufacturer == manufacturer)
                .ToListAsync();
        }

        public async Task<List<Aircraft>> GetByModelAsync(string model)
        {
            return await _context.Aircrafts
                .Where(a => a.Model == model)
                .ToListAsync();
        }

        public async Task<List<Aircraft>> GetNewerThanYearAsync(int year)
        {
            return await _context.Aircrafts
                .Where(a => a.Year > year)
                .ToListAsync();
        }

        public async Task<List<Aircraft>> GetWithFlightHoursLessThanAsync(int maxHours)
        {
            return await _context.Aircrafts
                .Where(a => a.FlightHours < maxHours)
                .ToListAsync();
        }

    }

    
}

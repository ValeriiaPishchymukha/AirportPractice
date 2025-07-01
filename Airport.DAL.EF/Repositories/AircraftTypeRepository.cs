using Airport.DAL.EF.Entities;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
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
        public async Task<PagedList<AircraftType>> GetAllAsync(AircraftTypeParameters parameters)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameters.TypeName))
                query = query.Where(a => a.TypeName.Contains(parameters.TypeName));

            return await PagedList<AircraftType>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
        }
        public async Task<List<AircraftType>> GetTypesWithAircraftsAsync()
        {
            return await _context.AircraftTypes
                .Where(t => t.Aircrafts.Any())
                .ToListAsync();
        }
    }
    
}

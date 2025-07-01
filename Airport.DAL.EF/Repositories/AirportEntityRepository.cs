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
    public class AirportEntityRepository : GenericRepository<AirportEntity>, IAirportEntityRepository
    {
        public AirportEntityRepository(AirportDbContext context) : base(context)
        {
        }
        public async Task<PagedList<AirportEntity>> GetAllAsync(AirportEntityParameters parameters)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameters.Name))
                query = query.Where(a => a.Name.Contains(parameters.Name));

            if (!string.IsNullOrWhiteSpace(parameters.Country))
                query = query.Where(a => a.Country.Contains(parameters.Country));


            return await PagedList<AirportEntity>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
        }
        public async Task<List<AirportEntity>> GetAirportsByCountryAsync(string country)
        {
            return await _context.Airports
                .Where(a => a.Country == country)
                .ToListAsync();
        }
    }
}

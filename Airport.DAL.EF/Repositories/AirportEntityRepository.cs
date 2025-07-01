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

            if (!string.IsNullOrWhiteSpace(parameters.OrderBy))
            {
                switch (parameters.OrderBy.ToLower())
                {
                    case "id":
                        query = query.OrderBy(a => a.Id);
                        break;
                    case "id desc":
                        query = query.OrderByDescending(a => a.Id);
                        break;
                    case "name":
                        query = query.OrderBy(a => a.Name);
                        break;
                    case "name desc":
                        query = query.OrderByDescending(a => a.Name);
                        break;
                    case "country":
                        query = query.OrderBy(a => a.Country);
                        break;
                    case "country desc":
                        query = query.OrderByDescending(a => a.Country);
                        break;
                    default:
                        query = query.OrderBy(a => a.Id);
                        break;
                }
            }
            else
            {
                query = query.OrderBy(a => a.Id);
            }


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

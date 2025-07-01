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
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(AirportDbContext context) : base(context)
        {
        }
        public async Task<PagedList<Passenger>> GetAllAsync(PassengerParameters parameters)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameters.FullName))
                query = query.Where(p => p.FullName.Contains(parameters.FullName));

            if (!string.IsNullOrWhiteSpace(parameters.Email))
                query = query.Where(p => p.Email.Contains(parameters.Email));

            if (!string.IsNullOrWhiteSpace(parameters.OrderBy))
            {
                switch (parameters.OrderBy.ToLower())
                {
                    case "id":
                        query = query.OrderBy(p => p.Id);
                        break;
                    case "id desc":
                        query = query.OrderByDescending(p => p.Id);
                        break;
                    case "fullname":
                        query = query.OrderBy(p => p.FullName);
                        break;
                    case "fullname desc":
                        query = query.OrderByDescending(p => p.FullName);
                        break;
                    case "email":
                        query = query.OrderBy(p => p.Email);
                        break;
                    case "email desc":
                        query = query.OrderByDescending(p => p.Email);
                        break;
                    default:
                        query = query.OrderBy(p => p.Id);
                        break;
                }
            }
            else
            {
                query = query.OrderBy(p => p.Id);
            }


            return await PagedList<Passenger>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
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

        public async Task<List<AirportEntity>> GetDestinationsByPassengerNameAsync(string fullName)
        {
            var passenger = await _context.Passengers
                .Include(p => p.FlightDestinations)
                .ThenInclude(fd => fd.Airport)
                .FirstOrDefaultAsync(p => p.FullName == fullName);

            if (passenger == null || passenger.FlightDestinations == null)
                return new List<AirportEntity>();

            return passenger.FlightDestinations
                .Select(fd => fd.Airport)
                .ToList();
        }
    }
}

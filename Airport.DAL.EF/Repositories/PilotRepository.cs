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
    public class PilotRepository : GenericRepository<Pilot>, IPilotRepository
    {
        public PilotRepository(AirportDbContext context) : base(context) { }

        public async Task<PagedList<Pilot>> GetAllAsync(PilotParameters parameters)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameters.FirstName))
                query = query.Where(p => p.FirstName.Contains(parameters.FirstName));

            if (!string.IsNullOrWhiteSpace(parameters.LastName))
                query = query.Where(p => p.LastName.Contains(parameters.LastName));

            if (parameters.MinAge.HasValue)
                query = query.Where(p => p.Age >= parameters.MinAge.Value);

            if (parameters.MaxAge.HasValue)
                query = query.Where(p => p.Age <= parameters.MaxAge.Value);

            if (parameters.MinRating.HasValue)
                query = query.Where(p => p.Rating >= parameters.MinRating.Value);

            if (parameters.MaxRating.HasValue)
                query = query.Where(p => p.Rating <= parameters.MaxRating.Value);

            return await PagedList<Pilot>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
        }
        public override async Task<Pilot> GetByIDAsync(int id)
        {
            return await _dbSet
                .Include(p => p.PilotAircrafts)
                    .ThenInclude(pa => pa.Aircraft)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

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
            return await _dbSet
                .Include(p => p.PilotAircrafts)          
                .ThenInclude(pa => pa.Aircraft)          
                .FirstOrDefaultAsync(p => p.FirstName == firstName && p.LastName == lastName);
        }

        public override void Update(Pilot entity)
        {
            var existingPilotAircrafts = _context.PilotAircrafts
                .Where(pa => pa.PilotId == entity.Id)
                .ToList();

            foreach (var existingPa in existingPilotAircrafts)
            {
                if (!entity.PilotAircrafts.Any(pa => pa.AircraftId == existingPa.AircraftId))
                {
                    _context.PilotAircrafts.Remove(existingPa);
                }
            }

            foreach (var newPa in entity.PilotAircrafts)
            {
                if (!existingPilotAircrafts.Any(pa => pa.AircraftId == newPa.AircraftId))
                {
                    _context.PilotAircrafts.Add(newPa);
                }
            }

            _dbSet.Update(entity);
        }

    }
}

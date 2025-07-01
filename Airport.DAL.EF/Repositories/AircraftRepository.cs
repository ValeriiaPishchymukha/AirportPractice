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
    public class AircraftRepository : GenericRepository<Aircraft>, IAircraftRepository
    {
        public AircraftRepository(AirportDbContext context) : base(context)
        {
        }
        public async Task<PagedList<Aircraft>> GetAllAsync(AircraftParameters parameters)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrWhiteSpace(parameters.Manufacturer))
                query = query.Where(a => a.Manufacturer.Contains(parameters.Manufacturer));

            if (!string.IsNullOrWhiteSpace(parameters.Model))
                query = query.Where(a => a.Model.Contains(parameters.Model));

            if (parameters.MinYear.HasValue)
                query = query.Where(a => a.Year >= parameters.MinYear.Value);

            if (parameters.MaxYear.HasValue)
                query = query.Where(a => a.Year <= parameters.MaxYear.Value);

            if (parameters.MaxFlightHours.HasValue)
                query = query.Where(a => a.FlightHours <= parameters.MaxFlightHours.Value);

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
                    case "manufacturer":
                        query = query.OrderBy(a => a.Manufacturer);
                        break;
                    case "manufacturer desc":
                        query = query.OrderByDescending(a => a.Manufacturer);
                        break;
                    case "model":
                        query = query.OrderBy(a => a.Model);
                        break;
                    case "model desc":
                        query = query.OrderByDescending(a => a.Model);
                        break;
                    case "year":
                        query = query.OrderBy(a => a.Year);
                        break;
                    case "year desc":
                        query = query.OrderByDescending(a => a.Year);
                        break;
                    case "flighthours":
                        query = query.OrderBy(a => a.FlightHours);
                        break;
                    case "flighthours desc":
                        query = query.OrderByDescending(a => a.FlightHours);
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

            return await PagedList<Aircraft>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Aircraft> GetByIDAsync(int id)
        {
            return await _context.Aircrafts
                .Include(a => a.AircraftType) 
                .Include(a => a.PilotAircrafts) 
                    .ThenInclude(pa => pa.Pilot) 
                .FirstOrDefaultAsync(a => a.Id == id);
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

        public override void Update(Aircraft entity)
        {
            var existingPilotAircrafts = _context.Set<PilotAircraft>()
                .Where(pa => pa.AircraftId == entity.Id)
                .ToList();

            foreach (var existingPa in existingPilotAircrafts)
            {
                if (!entity.PilotAircrafts.Any(pa => pa.PilotId == existingPa.PilotId))
                {
                    _context.Set<PilotAircraft>().Remove(existingPa);
                }
            }

            foreach (var newPa in entity.PilotAircrafts)
            {
                if (!existingPilotAircrafts.Any(pa => pa.PilotId == newPa.PilotId))
                {
                    _context.Set<PilotAircraft>().Add(newPa);
                }
            }

            _dbSet.Update(entity);
        }
    }

    
}

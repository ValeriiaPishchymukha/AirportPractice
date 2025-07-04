﻿using Airport.DAL.EF.Entities;
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
    public class FlightDestinationRepository : GenericRepository<FlightDestination>, IFlightDestinationRepository
    {
        public FlightDestinationRepository(AirportDbContext context) : base(context) { 
        }

        public async Task<PagedList<FlightDestination>> GetAllAsync(FlightDestinationParameters parameters)
        {
            var query = _dbSet.AsQueryable();

            if (parameters.AirportId.HasValue)
                query = query.Where(fd => fd.AirportId == parameters.AirportId.Value);

            if (parameters.PassengerId.HasValue)
                query = query.Where(fd => fd.PassengerId == parameters.PassengerId.Value);

            if (parameters.AircraftId.HasValue)
                query = query.Where(fd => fd.AircraftId == parameters.AircraftId.Value);

            if (parameters.DepartureAfter.HasValue)
                query = query.Where(fd => fd.Departure >= parameters.DepartureAfter.Value);

            if (parameters.DepartureBefore.HasValue)
                query = query.Where(fd => fd.Departure <= parameters.DepartureBefore.Value);

            if (parameters.MinTicketPrice.HasValue)
                query = query.Where(fd => fd.TicketPrice >= parameters.MinTicketPrice.Value);

            if (parameters.MaxTicketPrice.HasValue)
                query = query.Where(fd => fd.TicketPrice <= parameters.MaxTicketPrice.Value);

            if (!string.IsNullOrWhiteSpace(parameters.OrderBy))
            {
                switch (parameters.OrderBy.ToLower())
                {
                    case "id":
                        query = query.OrderBy(fd => fd.Id);
                        break;
                    case "id desc":
                        query = query.OrderByDescending(fd => fd.Id);
                        break;

                    case "airportid":
                        query = query.OrderBy(fd => fd.AirportId);
                        break;
                    case "airportid desc":
                        query = query.OrderByDescending(fd => fd.AirportId);
                        break;

                    case "departure":
                        query = query.OrderBy(fd => fd.Departure);
                        break;
                    case "departure desc":
                        query = query.OrderByDescending(fd => fd.Departure);
                        break;

                    case "aircraftid":
                        query = query.OrderBy(fd => fd.AircraftId);
                        break;
                    case "aircraftid desc":
                        query = query.OrderByDescending(fd => fd.AircraftId);
                        break;

                    case "passengerid":
                        query = query.OrderBy(fd => fd.PassengerId);
                        break;
                    case "passengerid desc":
                        query = query.OrderByDescending(fd => fd.PassengerId);
                        break;

                    case "ticketprice":
                        query = query.OrderBy(fd => fd.TicketPrice);
                        break;
                    case "ticketprice desc":
                        query = query.OrderByDescending(fd => fd.TicketPrice);
                        break;

                    default:
                        query = query.OrderBy(fd => fd.Id);
                        break;
                }
            }
            else
            {
                query = query.OrderBy(fd => fd.Id);
            }

            return await PagedList<FlightDestination>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<List<FlightDestination>> GetFlightsByPassengerAsync(int passengerId)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.PassengerId == passengerId)
                .ToListAsync();
        }

        public async Task<List<FlightDestination>> GetUpcomingFlightsAsync(DateTime afterDate)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.Departure > afterDate)
                .ToListAsync();
        }

        public async Task<List<FlightDestination>> GetFlightsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.TicketPrice >= minPrice && fd.TicketPrice <= maxPrice)
                .ToListAsync();
        }

        public async Task<List<FlightDestination>> GetFlightsByAirportAsync(int airportId)
        {
            return await _context.FlightDestinations
                .Where(fd => fd.AirportId == airportId)
                .ToListAsync();
        }

        public override void Update(FlightDestination entity)
        {
            if (entity.Airport != null)
            {
                _context.Entry(entity.Airport).State = EntityState.Modified;
            }

            if (entity.Aircraft != null)
            {
                _context.Entry(entity.Aircraft).State = EntityState.Modified;
            }

            if (entity.Passenger != null)
            {
                _context.Entry(entity.Passenger).State = EntityState.Modified;
            }

            _context.Set<FlightDestination>().Update(entity);
        }
    }
}

using Airport.DAL.EF.Entities;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IFlightDestinationRepository : IGenericRepository<FlightDestination>
    {
        Task<PagedList<FlightDestination>> GetAllAsync(FlightDestinationParameters parameters);
        Task<List<FlightDestination>> GetFlightsByPassengerAsync(int passengerId);
        Task<List<FlightDestination>> GetUpcomingFlightsAsync(DateTime afterDate);
        Task<List<FlightDestination>> GetFlightsByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<List<FlightDestination>> GetFlightsByAirportAsync(int airportId);
    }
}

using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.DAL.EF.Entities.HelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Services.Interfaces
{
    public interface IFlightDestinationService
    {
        Task<List<FlightDestinationShortResponseDTO>> GetAllAsync(Parameters parameters);
        Task<FlightDestinationFullResponseDTO> GetByIDAsync(int id);
        Task<List<FlightDestinationShortResponseDTO>> GetFlightsByPassengerAsync(int passengerId);
        Task<List<FlightDestinationShortResponseDTO>> GetUpcomingFlightsAsync(DateTime afterDate);
        Task<List<FlightDestinationShortResponseDTO>> GetFlightsByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<List<FlightDestinationShortResponseDTO>> GetFlightsByAirportAsync(int airportId);
        Task CreateAsync(FlightDestinationReqDTO dto);
        Task UpdateAsync(int id, FlightDestinationReqDTO dto);
        Task DeleteAsync(int id);
    }
}

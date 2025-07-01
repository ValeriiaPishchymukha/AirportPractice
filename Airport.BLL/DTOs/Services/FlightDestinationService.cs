using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services.Interfaces;
using Airport.DAL.EF.Entities;
using Airport.DAL.EF.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Services
{
    public class FlightDestinationService : IFlightDestinationService
    {
        private readonly IFlightDestinationRepository _repository;
        private readonly IMapper _mapper;

        public FlightDestinationService(IFlightDestinationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<FlightDestinationShortResponseDTO>> GetAllAsync()
        {
            var flights = await _repository.GetAllAsync();
            return _mapper.Map<List<FlightDestinationShortResponseDTO>>(flights);
        }

        public async Task<FlightDestinationFullResponseDTO> GetByIDAsync(int id)
        {
            var flight = await _repository.GetByIDAsync(id);
            return _mapper.Map<FlightDestinationFullResponseDTO>(flight);
        }

        public async Task<List<FlightDestinationShortResponseDTO>> GetFlightsByPassengerAsync(int passengerId)
        {
            var flights = await _repository.GetFlightsByPassengerAsync(passengerId);
            return _mapper.Map<List<FlightDestinationShortResponseDTO>>(flights);
        }

        public async Task<List<FlightDestinationShortResponseDTO>> GetUpcomingFlightsAsync(DateTime afterDate)
        {
            var flights = await _repository.GetUpcomingFlightsAsync(afterDate);
            return _mapper.Map<List<FlightDestinationShortResponseDTO>>(flights);
        }

        public async Task<List<FlightDestinationShortResponseDTO>> GetFlightsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            var flights = await _repository.GetFlightsByPriceRangeAsync(minPrice, maxPrice);
            return _mapper.Map<List<FlightDestinationShortResponseDTO>>(flights);
        }

        public async Task<List<FlightDestinationShortResponseDTO>> GetFlightsByAirportAsync(int airportId)
        {
            var flights = await _repository.GetFlightsByAirportAsync(airportId);
            return _mapper.Map<List<FlightDestinationShortResponseDTO>>(flights);
        }

        public async Task CreateAsync(FlightDestinationReqDTO dto)
        {
            var flight = _mapper.Map<FlightDestination>(dto);
            await _repository.CreateAsync(flight);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, FlightDestinationReqDTO dto)
        {
            var flight = await _repository.GetByIDAsync(id);
            if (flight == null)
                return;

            _mapper.Map(dto, flight);
            _repository.Update(flight);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var flight = await _repository.GetByIDAsync(id);
            if (flight != null)
            {
                _repository.Delete(flight);
                await _repository.SaveChangesAsync();
            }
        }
    }
}

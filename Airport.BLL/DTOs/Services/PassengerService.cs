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
    public class PassengerService : IPassengerService
    {
        private readonly IPassengerRepository _repository;
        private readonly IMapper _mapper;

        public PassengerService(IPassengerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<PassengerResponseDTO>> GetAllAsync()
        {
            var passengers = await _repository.GetAllAsync();
            return _mapper.Map<List<PassengerResponseDTO>>(passengers);
        }

        public async Task<PassengerResponseDTO> GetByIdAsync(int id)
        {
            var passenger = await _repository.GetByIDAsync(id);
            return _mapper.Map<PassengerResponseDTO>(passenger);
        }

        public async Task<PassengerResponseDTO> GetByEmailAsync(string email)
        {
            var passenger = await _repository.GetByEmailAsync(email);
            return _mapper.Map<PassengerResponseDTO>(passenger);
        }

        public async Task<List<PassengerResponseDTO>> SearchByNameAsync(string partialName)
        {
            var passengers = await _repository.SearchByNameAsync(partialName);
            return _mapper.Map<List<PassengerResponseDTO>>(passengers);
        }

        public async Task<List<(string AirportName, string Country)>> GetDestinationsByPassengerNameAsync(string fullName)
        {
            return await _repository.GetDestinationsByPassengerNameAsync(fullName);
        }

        public async Task CreateAsync(PassengerReqDTO dto)
        {
            var entity = _mapper.Map<Passenger>(dto);
            await _repository.CreateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, PassengerReqDTO dto)
        {
            var entity = await _repository.GetByIDAsync(id);
            if (entity == null)
                return;

            _mapper.Map(dto, entity);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIDAsync(id);
            if (entity != null)
            {
                _repository.Delete(entity);
                await _repository.SaveChangesAsync();
            }
        }
    }
}

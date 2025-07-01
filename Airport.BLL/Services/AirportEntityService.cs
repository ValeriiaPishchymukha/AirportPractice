using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.Services.Interfaces;
using Airport.DAL.EF.Entities;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
using Airport.DAL.EF.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.Services
{
    public class AirportEntityService : IAirportEntityService
    {
        private readonly IAirportEntityRepository _repository;
        private readonly IMapper _mapper;

        public AirportEntityService(IAirportEntityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AirportEntityResponseDTO>> GetAllAsync(AirportEntityParameters parameters)
        {
            var airports = await _repository.GetAllAsync(parameters);
            var dtoItems = _mapper.Map<List<AirportEntityResponseDTO>>(airports);

            return new PagedList<AirportEntityResponseDTO>(
                dtoItems,
                airports.TotalCount,
                airports.PageNumber,
                airports.PageSize
            );

        }

        public async Task<AirportEntityResponseDTO> GetByIDAsync(int id)
        {
            var airport = await _repository.GetByIDAsync(id);
            return _mapper.Map<AirportEntityResponseDTO>(airport);
        }

        public async Task<List<AirportEntityResponseDTO>> GetAirportsByCountryAsync(string country)
        {
            var airports = await _repository.GetAirportsByCountryAsync(country);
            return _mapper.Map<List<AirportEntityResponseDTO>>(airports);
        }

        public async Task CreateAsync(AirportEntityReqDTO dto)
        {
            var entity = _mapper.Map<AirportEntity>(dto);
            await _repository.CreateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, AirportEntityReqDTO dto)
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

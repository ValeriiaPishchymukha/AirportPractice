using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Services.Interfaces;
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

namespace Airport.BLL.DTOs.Services
{
    public class AircraftService : IAircraftService
    {
        private readonly IAircraftRepository _repository;
        private readonly IMapper _mapper;

        public AircraftService(IAircraftRepository aircraftRepository, IMapper mapper)
        {
            _repository = aircraftRepository;
            _mapper = mapper;
        }

        public async Task<List<AircraftShortResponseDTO>> GetAllAsync(AircraftParameters parameters)
        {
            var aircrafts = await _repository.GetAllAsync(parameters);
            var dtoItems = _mapper.Map<List<AircraftShortResponseDTO>>(aircrafts);

            return new PagedList<AircraftShortResponseDTO>(
                dtoItems,
                aircrafts.TotalCount,
                aircrafts.PageNumber,
                aircrafts.PageSize
            );

        }

        public async Task<AircraftFullResponseDTO> GetByIDAsync(int id)
        {
            var aircraft = await _repository.GetByIDAsync(id);

            if (aircraft == null)
                return null;

            return _mapper.Map<AircraftFullResponseDTO>(aircraft);
        }

        public async Task<List<AircraftShortResponseDTO>> GetByManufacturerAsync(string manufacturer)
        {
            var aircrafts = await _repository.GetByManufacturerAsync(manufacturer);
            return _mapper.Map<List<AircraftShortResponseDTO>>(aircrafts);
        }

        public async Task<List<AircraftShortResponseDTO>> GetByModelAsync(string model)
        {
            var aircrafts = await _repository.GetByModelAsync(model);
            return _mapper.Map<List<AircraftShortResponseDTO>>(aircrafts);
        }

        public async Task<List<AircraftShortResponseDTO>> GetNewerThanYearAsync(int year)
        {
            var aircrafts = await _repository.GetNewerThanYearAsync(year);
            return _mapper.Map<List<AircraftShortResponseDTO>>(aircrafts);
        }

        public async Task<List<AircraftShortResponseDTO>> GetWithFlightHoursLessThanAsync(int maxHours)
        {
            var aircrafts = await _repository.GetWithFlightHoursLessThanAsync(maxHours);
            return _mapper.Map<List<AircraftShortResponseDTO>>(aircrafts);
        }

        public async Task CreateAsync(AircraftReqDTO dto)
        {
            var entity = _mapper.Map<Aircraft>(dto);

            if (dto.PilotIds != null && dto.PilotIds.Any())
            {
                entity.PilotAircrafts = new List<PilotAircraft>();

                foreach (var pilotId in dto.PilotIds)
                {
                    entity.PilotAircrafts.Add(new PilotAircraft
                    {
                        PilotId = pilotId
                    });
                }
            }

            await _repository.CreateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, AircraftReqDTO dto)
        {
            var aircraft = await _repository.GetByIDAsync(id);
            if (aircraft == null)
                return;

            _mapper.Map(dto, aircraft);

            if (dto.PilotIds != null)
            {
                aircraft.PilotAircrafts = dto.PilotIds.Select(pid => new PilotAircraft
                {
                    PilotId = pid,
                    AircraftId = aircraft.Id
                }).ToList();
            }

            _repository.Update(aircraft);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var aircraft = await _repository.GetByIDAsync(id);
            if (aircraft == null)
                return;

            _repository.Delete(aircraft);
            await _repository.SaveChangesAsync();
        }
    }
}

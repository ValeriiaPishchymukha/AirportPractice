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
    public class PilotService : IPilotService
    {
        private readonly IPilotRepository _repository;
        private readonly IMapper _mapper;

        public PilotService(IPilotRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<PilotShortResponseDTO>> GetAllAsync(PilotParameters parameters)
        {
            var pilots = await _repository.GetAllAsync(parameters);
            var dtoItems = _mapper.Map<List<PilotShortResponseDTO>>(pilots);

            return new PagedList<PilotShortResponseDTO>(
                dtoItems,
                pilots.TotalCount,
                pilots.PageNumber,
                pilots.PageSize
            );

        }

        public async Task<PilotFullResponseDTO> GetByIDAsync(int id)
        {
            var pilot = await _repository.GetByIDAsync(id);
            if (pilot == null)
                return null;

            return _mapper.Map<PilotFullResponseDTO>(pilot);
        }

        public async Task<List<PilotShortResponseDTO>> GetPilotsWithRatingAboveAsync(double minRating)
        {
            var pilots = await _repository.GetPilotsWithRatingAboveAsync(minRating);
            return _mapper.Map<List<PilotShortResponseDTO>>(pilots);
        }

        public async Task<List<PilotShortResponseDTO>> GetPilotsByAgeRangeAsync(int minAge, int maxAge)
        {
            var pilots = await _repository.GetPilotsByAgeRangeAsync(minAge, maxAge);
            return _mapper.Map<List<PilotShortResponseDTO>>(pilots);
        }

        public async Task<PilotFullResponseDTO> GetPilotByFullNameAsync(string firstName, string lastName)
        {
            var pilot = await _repository.GetPilotByFullNameAsync(firstName, lastName);
            if (pilot == null)
                return null;

            return _mapper.Map<PilotFullResponseDTO>(pilot);
        }

        public async Task CreateAsync(PilotReqDTO dto)
        {
            var entity = _mapper.Map<Pilot>(dto);

            if (dto.AircraftIds != null && dto.AircraftIds.Any())
            {
                entity.PilotAircrafts = new List<PilotAircraft>();

                foreach (var aircraftId in dto.AircraftIds)
                {
                    entity.PilotAircrafts.Add(new PilotAircraft
                    {
                        AircraftId = aircraftId
                    });
                }
            }

            await _repository.CreateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, PilotReqDTO dto)
        {
            var pilot = await _repository.GetByIDAsync(id);
            if (pilot == null)
                return;

            _mapper.Map(dto, pilot);

            if (dto.AircraftIds != null)
            {
                pilot.PilotAircrafts = dto.AircraftIds.Select(aid => new PilotAircraft
                {
                    AircraftId = aid,
                    PilotId = pilot.Id
                }).ToList();
            }

            _repository.Update(pilot);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pilot = await _repository.GetByIDAsync(id);
            if (pilot == null)
                return;

            _repository.Delete(pilot);
            await _repository.SaveChangesAsync();
        }
    }
}

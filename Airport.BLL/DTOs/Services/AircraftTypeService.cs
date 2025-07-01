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
    public class AircraftTypeService : IAircraftTypeService
    {
        private readonly IAircraftTypeRepository _repository;
        private readonly IMapper _mapper;

        public AircraftTypeService(IAircraftTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AircraftTypeResponseDTO>> GetAllAsync(AircraftTypeParameters parameters)
        {
            var types = await _repository.GetAllAsync(parameters);
            var dtoItems = _mapper.Map<List<AircraftTypeResponseDTO>>(types);

            return new PagedList<AircraftTypeResponseDTO>(
                dtoItems,
                types.TotalCount,
                types.PageNumber,
                types.PageSize
            );

        }

        public async Task<List<AircraftTypeResponseDTO>> GetTypesWithAircraftsAsync()
        {
            var types = await _repository.GetTypesWithAircraftsAsync();
            return _mapper.Map<List<AircraftTypeResponseDTO>>(types);
        }

        public async Task<AircraftTypeResponseDTO> GetByIDAsync(int id)
        {
            var type = await _repository.GetByIDAsync(id);
            return _mapper.Map<AircraftTypeResponseDTO>(type);
        }

        public async Task CreateAsync(AircraftTypeReqDTO dto)
        {
            var entity = _mapper.Map<AircraftType>(dto);
            await _repository.CreateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, AircraftTypeReqDTO dto)
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

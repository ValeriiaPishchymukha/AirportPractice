using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Services.Interfaces
{
    public interface IAircraftTypeService
    {
        Task<List<AircraftTypeResponseDTO>> GetAllAsync(AircraftTypeParameters parameters);
        Task<AircraftTypeResponseDTO> GetByIDAsync(int id);
        Task<List<AircraftTypeResponseDTO>> GetTypesWithAircraftsAsync();
        Task CreateAsync(AircraftTypeReqDTO dto);
        Task UpdateAsync(int id, AircraftTypeReqDTO dto);
        Task DeleteAsync(int id);
    }

}

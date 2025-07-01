using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Services.Interfaces
{
    public interface IAircraftTypeService
    {
        Task<List<AircraftTypeResponseDTO>> GetAllAsync();
        Task<AircraftTypeResponseDTO> GetByIDAsync(int id);
        Task<List<AircraftTypeResponseDTO>> GetTypesWithAircraftsAsync();
        Task CreateAsync(AircraftTypeReqDTO dto);
        Task UpdateAsync(int id, AircraftTypeReqDTO dto);
        Task DeleteAsync(int id);
    }

}

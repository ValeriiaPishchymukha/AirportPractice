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
    public interface IAircraftService
    {
        Task<List<AircraftShortResponseDTO>> GetAllAsync(AircraftParameters parameters);
        Task<AircraftFullResponseDTO> GetByIDAsync(int id);
        Task<List<AircraftShortResponseDTO>> GetByManufacturerAsync(string manufacturer);
        Task<List<AircraftShortResponseDTO>> GetByModelAsync(string model);
        Task<List<AircraftShortResponseDTO>> GetNewerThanYearAsync(int year);
        Task<List<AircraftShortResponseDTO>> GetWithFlightHoursLessThanAsync(int maxHours);
        Task CreateAsync(AircraftReqDTO dto);
        Task UpdateAsync(int id, AircraftReqDTO dto);
        Task DeleteAsync(int id);
    }
}

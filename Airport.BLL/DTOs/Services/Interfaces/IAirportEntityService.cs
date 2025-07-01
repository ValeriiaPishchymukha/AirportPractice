using Airport.BLL.DTOs.Responses;
using Airport.BLL.DTOs.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Services.Interfaces
{
    public interface IAirportEntityService
    {
        Task<List<AirportEntityResponseDTO>> GetAllAsync();
        Task<AirportEntityResponseDTO> GetByIDAsync(int id);
        Task<List<AirportEntityResponseDTO>> GetAirportsByCountryAsync(string country);
        Task CreateAsync(AirportEntityReqDTO dto);
        Task UpdateAsync(int id, AirportEntityReqDTO dto);
        Task DeleteAsync(int id);
    }
}

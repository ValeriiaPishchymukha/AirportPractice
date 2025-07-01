using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.Services.Interfaces
{
    public interface IPassengerService
    {
        Task<List<PassengerResponseDTO>> GetAllAsync(PassengerParameters parameters);
        Task<PassengerResponseDTO> GetByIdAsync(int id);
        Task<PassengerResponseDTO> GetByEmailAsync(string email);
        Task<List<PassengerResponseDTO>> SearchByNameAsync(string partialName);
        Task<List<AirportEntityResponseDTO>> GetDestinationsByPassengerNameAsync(string fullName);
        Task CreateAsync(PassengerReqDTO dto);
        Task UpdateAsync(int id, PassengerReqDTO dto);
        Task DeleteAsync(int id);
    }
}

using Airport.BLL.DTOs.Requests;
using Airport.BLL.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.BLL.DTOs.Services.Interfaces
{
    public interface IPilotService
    {
        Task<List<PilotShortResponseDTO>> GetAllAsync();
        Task<PilotFullResponseDTO> GetByIDAsync(int id);
        Task<List<PilotShortResponseDTO>> GetPilotsWithRatingAboveAsync(double minRating);
        Task<List<PilotShortResponseDTO>> GetPilotsByAgeRangeAsync(int minAge, int maxAge);
        Task<PilotFullResponseDTO> GetPilotByFullNameAsync(string firstName, string lastName);
        Task CreateAsync(PilotReqDTO dto);
        Task UpdateAsync(int id, PilotReqDTO dto);
        Task DeleteAsync(int id);
    }
}

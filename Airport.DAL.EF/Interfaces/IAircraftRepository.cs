using Airport.DAL.EF.Entities;
using Airport.DAL.EF.Entities.HelpModels.Filtration;
using Airport.DAL.EF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IAircraftRepository : IGenericRepository<Aircraft>
    {
        Task<PagedList<Aircraft>> GetAllAsync(AircraftParameters parameters);
        Task<List<Aircraft>> GetByManufacturerAsync(string manufacturer);
        Task<List<Aircraft>> GetByModelAsync(string model);
        Task<List<Aircraft>> GetNewerThanYearAsync(int year);
        Task<List<Aircraft>> GetWithFlightHoursLessThanAsync(int maxHours);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.DAL.EF.Entities;

namespace Airport.DAL.EF.Interfaces
{
    public interface IAircraftRepository : IGenericRepository<Aircraft>
    {
        Task<List<Aircraft>> GetByManufacturerAsync(string manufacturer);
        Task<List<Aircraft>> GetByModelAsync(string model);
        Task<List<Aircraft>> GetNewerThanYearAsync(int year);
        Task<List<Aircraft>> GetWithFlightHoursLessThanAsync(int maxHours);
    }
}

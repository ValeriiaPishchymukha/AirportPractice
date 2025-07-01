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
    public interface IPassengerRepository : IGenericRepository<Passenger>
    {
        Task<PagedList<Passenger>> GetAllAsync(PassengerParameters parameters);
        Task<Passenger> GetByEmailAsync(string email);
        Task<List<Passenger>> SearchByNameAsync(string partialName);
        Task<List<AirportEntity>> GetDestinationsByPassengerNameAsync(string fullName);

    }
}

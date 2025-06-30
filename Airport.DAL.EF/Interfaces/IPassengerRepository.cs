using Airport.DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IPassengerRepository : IGenericRepository<Passenger>
    {
        Task<Passenger> GetByEmailAsync(string email);
        Task<List<Passenger>> SearchByNameAsync(string partialName);
        Task<List<(string AirportName, string Country)>> GetDestinationsByPassengerNameAsync(string fullName);

    }
}

using Airport.DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IAirportEntityRepository : IGenericRepository<AirportEntity>
    {
        Task<List<AirportEntity>> GetAirportsByCountryAsync(string country);
    }
}

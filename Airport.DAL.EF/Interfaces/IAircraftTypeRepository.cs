using Airport.DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IAircraftTypeRepository : IGenericRepository<AircraftType>
    {
        Task<List<AircraftType>> GetTypesWithAircraftsAsync();
    }
}

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
    public interface IAircraftTypeRepository : IGenericRepository<AircraftType>
    {
        Task<PagedList<AircraftType>> GetAllAsync(AircraftTypeParameters parameters);
        Task<List<AircraftType>> GetTypesWithAircraftsAsync();
    }
}

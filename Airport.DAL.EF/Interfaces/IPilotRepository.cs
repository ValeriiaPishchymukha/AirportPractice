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
    public interface IPilotRepository : IGenericRepository<Pilot>
    {
        Task<PagedList<Pilot>> GetAllAsync(PilotParameters parameters);
        Task<List<Pilot>> GetPilotsWithRatingAboveAsync(double minRating);
        Task<List<Pilot>> GetPilotsByAgeRangeAsync(int minAge, int maxAge);
        Task<Pilot> GetPilotByFullNameAsync(string firstName, string lastName);
    }
}

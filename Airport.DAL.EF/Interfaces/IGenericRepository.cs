using Airport.DAL.EF.Entities.HelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Interfaces
{
    public interface IGenericRepository<Entity> where Entity : BaseModel
    {
        Task<List<Entity>> GetAllAsync();
        Task<Entity> GetByIDAsync(int id);
        Task CreateAsync(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
        Task SaveChangesAsync();
    }
}

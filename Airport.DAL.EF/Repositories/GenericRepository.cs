﻿using Airport.DAL.EF.Entities.HelpModels;
using Airport.DAL.EF.Helpers;
using Airport.DAL.EF.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.DAL.EF.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : BaseModel
    {
        public readonly AirportDbContext _context;
        public DbSet<Entity> _dbSet;
        public GenericRepository(AirportDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();
        }

        public virtual async Task<PagedList<Entity>> GetAllAsync(Parameters parameters)
        {
            var query = _dbSet.AsQueryable();

            return await PagedList<Entity>.CreateAsync(query, parameters.PageNumber, parameters.PageSize);
        }

        public virtual async Task<Entity> GetByIDAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(Entity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual void Update(Entity entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(Entity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}

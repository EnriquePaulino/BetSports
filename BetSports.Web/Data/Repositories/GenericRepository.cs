﻿using BetSports.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly DataContext _dataContext;

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dataContext.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dataContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> GetMaxIdBankingAsync()
        {
            return await _dataContext.Set<T>()
                .AsNoTracking()
                .MaxAsync();
        }
        public async Task CreateAsync(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dataContext.Set<T>().Update(entity);
            await SaveAllAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataContext.Set<T>().AnyAsync(e => e.Id == id);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }
    }
}


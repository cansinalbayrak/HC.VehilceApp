using HC.VehicleApp.Entities.Abstract;
using HC.VehicleApp.Entities.Enums;
using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HC.VehilceApp.DAL.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        protected IQueryable<T> GetAllActives(bool tracking = true)
        {
            var values = _dbSet.Where(x => x.Status != Status.Deleted);
            return tracking ? values : values.AsNoTracking();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            await Task.FromResult(_dbSet.Remove(entity));
        }

        public async Task<List<T>> GetAllAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            var values = GetAllActives(asNoTracking);
            if (filter != null)
            {
                values = values.Where(filter);

            }
            if (includeProperties.Any())
            {
                foreach (var property in includeProperties)
                {
                    values = values.Include(property);

                }
            }

            return await values.ToListAsync();

        }

        public async Task<T> GetAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            var values = GetAllActives(asNoTracking);
            if (filter != null)
            {
                values = values.Where(filter);

            }
            if (includeProperties.Any())
            {
                foreach (var property in includeProperties)
                {
                    values = values.Include(property);

                }
            }

            return await values.FirstOrDefaultAsync();
        }

        public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
        {
            var values = GetAllActives(tracking);

            return await values.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.FromResult(_dbSet.Update(entity));
            
        }
    }
}

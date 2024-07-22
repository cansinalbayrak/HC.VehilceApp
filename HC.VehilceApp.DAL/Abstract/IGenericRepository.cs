using HC.VehicleApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Abstract
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        Task<T> GetByIdAsync(Guid id, bool tracking = true);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<List<T>> GetAllAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties);
    }
}

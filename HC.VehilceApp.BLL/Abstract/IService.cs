using HC.VehicleApp.Entities.Abstract;
using HC.VehilceApp.BLL.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Abstract
{
    public interface IService<T, TDto, TCreateDto, TUpdateDto, TListDto> where T : class, IEntity 
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
        where TListDto : class
    {
        Task<IResult> InsertAsync(TCreateDto dto);
        Task<IResult> UpdateAsync(TUpdateDto dto);
        Task<IResult> DeleteAsync(Guid id);
        Task<IResult> GetByIdAsync(Guid id, bool tracking = true);
        Task<IResult> GetAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties);
        Task<IResult> GetAllAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties);
    }
}

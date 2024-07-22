using HC.VehicleApp.Entities.Abstract;
using HC.VehilceApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Uow
{
    public interface IUow
    {
        Task SaveChangesAsync();
        IGenericRepository<T> GetRepository<T>() where T: class, IEntity;
        

    }
}

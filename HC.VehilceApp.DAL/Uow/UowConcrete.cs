using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Concrete;
using HC.VehilceApp.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Uow
{
    public class UowConcrete : IUow
    {
        private readonly AppDbContext _dbContext;

        public UowConcrete(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        IGenericRepository<T> IUow.GetRepository<T>()
        {
            return new GenericRepository<T>(_dbContext);
        }
    }
}

using HC.VehicleApp.Entities.Concrete;
using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Concrete
{
    public class BusRepository : GenericRepository<Bus>, IBusRepository
    {
        public BusRepository(AppDbContext context) : base(context)
        {
        }
    }
}

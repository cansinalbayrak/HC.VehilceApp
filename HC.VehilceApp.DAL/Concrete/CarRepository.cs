﻿using HC.VehicleApp.Entities.Concrete;
using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Concrete
{
    public class CarRepository : GenericRepository<Car>, ICarRespository
    {
        public CarRepository(AppDbContext context) : base(context)
        {
        }

    }
}

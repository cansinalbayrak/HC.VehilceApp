using HC.VehilceApp.BLL.Abstract;
using HC.VehilceApp.BLL.Concrete;
using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Concrete;
using HC.VehilceApp.DAL.Contexts;
using HC.VehilceApp.DAL.Uow;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.BLL.Extensions
{
    public static class BLLDependencies
    {
        public static IServiceCollection AddBLLDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IBoatService, BoatService>();
            

            return services;
        }
    }
}

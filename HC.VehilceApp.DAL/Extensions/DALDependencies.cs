using HC.VehilceApp.DAL.Abstract;
using HC.VehilceApp.DAL.Concrete;
using HC.VehilceApp.DAL.Contexts;
using HC.VehilceApp.DAL.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Extensions
{
    public static class DALDependencies
    {
        public static IServiceCollection AddDALDependencies(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("InMemoryDb"));

            #region Uow and Repositories
            services.AddScoped<ICarRespository, CarRepository>();
            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();
            services.AddScoped<IUow, UowConcrete>();
            #endregion

            return services;
        }
    }
}

using HC.VehicleApp.Entities.Abstract;
using HC.VehicleApp.Entities.Concrete;
using HC.VehicleApp.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehilceApp.DAL.Contexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            SetBaseProperties();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetBaseProperties();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            //foreach (var entry in entries)
            //{
            //    SetIfAdded(entry);
            //    SetIfModified(entry);
            //    SetIfDeleted(entry);
            //}
            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        SetIfAdded(entry);
                        break;
                    case EntityState.Modified:
                        SetIfModified(entry);
                        break;
                    case EntityState.Deleted:
                        SetIfDeleted(entry);
                        break;
                }
            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {
            

            entry.State = EntityState.Modified;

            entry.Entity.Status = Status.Deleted;
            entry.Entity.DeletedDate = DateTime.Now;
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            
                
                entry.Entity.Status = Status.Modified;
                entry.Entity.ModifiedDate = DateTime.Now;
           
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            

            entry.Entity.Status = Status.Added;
            entry.Entity.CreatedDate = DateTime.Now;
        }

    }
}

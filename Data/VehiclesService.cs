using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CarM8_01.Data
{
    public class VehiclesService
    {
        private readonly Carm8dataContext _context;

        public VehiclesService(Carm8dataContext context)
        {
            _context = context;
        }

        public IQueryable<Vehicles> GetVehicles()
        {
            return _context.Vehicles.AsNoTracking();
        }

        //public async Task<Vehicles> GetVehiclesAsync(string VehicleID)
        //{ // Get the existing vehicle
        //    var ExistingVehicle = await _context.Vehicles
        //        .Where(x => x.VehicleId == VehicleID)
        //        .AsNoTracking()
        //        .FirstOrDefaultAsync();

        //    return ExistingVehicle;
        //}

        public Task<Vehicles> CreateVehicleAsync(Vehicles newVehicles)
        {
            try
            {
                // Add a new help desk ticket.
                _context.Vehicles.Add(newVehicles);
                _context.SaveChanges();

                return Task.FromResult(newVehicles);
            }
            catch (Exception ex)
            {
                DetachAllEntities();
                throw ex;
            }
        }

        public void DetachAllEntities()
        { // When we have an error, we need
          // to remove EF Core change tracking.
            var changedEntriesCopy = _context.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();
            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }
    }
}
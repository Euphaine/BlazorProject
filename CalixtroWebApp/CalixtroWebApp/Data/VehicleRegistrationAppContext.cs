using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalixtroWebApp.vehicle_registration.Models;

namespace CalixtroWebApp.Data
{
    public class VehicleRegistrationAppContext : DbContext
    {
        public VehicleRegistrationAppContext (DbContextOptions<VehicleRegistrationAppContext> options)
            : base(options)
        {
        }

        public DbSet<CalixtroWebApp.vehicle_registration.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}

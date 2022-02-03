#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage_2._0.Models;

namespace Garage_2._0.Data
{
    public class Garage_2_0Context : DbContext
    {
         public DbSet<Vehicle> Vehicle { get; set; }

        public Garage_2_0Context (DbContextOptions<Garage_2_0Context> options)
            : base(options)
        {
        }

       

         protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicle>()
                .HasData(
                new Vehicle { Id = 1, Parked = false, RegNo = "FHX010",  ArrivalTime = DateTime.Now, Brand = "Volvo", Model = "V60", NoOfWheels = 4, Color = "Svart", vehicleType = VehicleType.Car},
                new Vehicle { Id = 2, Parked = false, RegNo = "HHS407",  ArrivalTime = DateTime.Now, Brand = "Toyota", Model = "Celica Supra", NoOfWheels = 4, Color = "Blå", vehicleType = VehicleType.Car},
                new Vehicle { Id = 3, Parked = false, RegNo = "XRE565",  ArrivalTime = DateTime.Now, Brand = "Mercedes-Benz", Model = "Arocs", NoOfWheels = 6, Color = "Vit", vehicleType = VehicleType.Lorry},
                new Vehicle { Id = 4, Parked = false, RegNo = "MLB803",  ArrivalTime = DateTime.Now, Brand = "Scania", Model = "", NoOfWheels = 8, Color = "Svart", vehicleType = VehicleType.Bus},
                new Vehicle { Id = 5, Parked = false, RegNo = "MXW413",  ArrivalTime = DateTime.Now, Brand = "BMV", Model = "", NoOfWheels = 6, Color = "Svart", vehicleType = VehicleType.Van}
                );
        }
    }
}

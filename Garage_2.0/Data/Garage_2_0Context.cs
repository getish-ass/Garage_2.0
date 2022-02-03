#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage_2._0.Models;
using Garage_2._0.Models.Entities;

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
                new Vehicle { Id = 1, Parked = true, RegNo = "FHX010",  ArrivalTime = DateTime.Now, Brand = "Volvo", Model = "V60", NoOfWheels = 4, Color = "Svart", VehicleType = VehicleType.Bil},
                new Vehicle { Id = 2, Parked = true, RegNo = "HHS407",  ArrivalTime = DateTime.Now, Brand = "Toyota", Model = "Celica Supra", NoOfWheels = 4, Color = "Blå", VehicleType = VehicleType.Bil},
                new Vehicle { Id = 3, Parked = true, RegNo = "XRE565",  ArrivalTime = DateTime.Now, Brand = "Mercedes-Benz", Model = "Arocs", NoOfWheels = 6, Color = "Vit", VehicleType = VehicleType.Lastbil},
                new Vehicle { Id = 4, Parked = true, RegNo = "MLB803",  ArrivalTime = DateTime.Now, Brand = "Scania", Model = "", NoOfWheels = 8, Color = "Svart", VehicleType = VehicleType.Buss},
                new Vehicle { Id = 5, Parked = true, RegNo = "MXW413",  ArrivalTime = DateTime.Now, Brand = "BMV", Model = "", NoOfWheels = 6, Color = "Svart", VehicleType = VehicleType.Van}
                );
        }
    }
}

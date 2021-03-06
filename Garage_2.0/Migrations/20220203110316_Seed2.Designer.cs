// <auto-generated />
using System;
using Garage_2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage_2._0.Migrations
{
    [DbContext(typeof(Garage_2_0Context))]
    [Migration("20220203110316_Seed2")]
    partial class Seed2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Garage_2._0.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Color")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Model")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("NoOfWheels")
                        .HasColumnType("int");

                    b.Property<bool>("Parked")
                        .HasColumnType("bit");

                    b.Property<string>("RegNo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = new DateTime(2022, 2, 3, 12, 3, 16, 99, DateTimeKind.Local).AddTicks(7072),
                            Brand = "Volvo",
                            Color = "Black",
                            Model = "V60",
                            NoOfWheels = 4,
                            Parked = true,
                            RegNo = "FHX010",
                            VehicleType = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = new DateTime(2022, 2, 3, 12, 3, 16, 99, DateTimeKind.Local).AddTicks(7105),
                            Brand = "Toyota",
                            Color = "Blue",
                            Model = "Celica Supra",
                            NoOfWheels = 4,
                            Parked = true,
                            RegNo = "HHS407",
                            VehicleType = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalTime = new DateTime(2022, 2, 3, 12, 3, 16, 99, DateTimeKind.Local).AddTicks(7108),
                            Brand = "Mercedes-Benz",
                            Color = "White",
                            Model = "Arocs",
                            NoOfWheels = 6,
                            Parked = true,
                            RegNo = "XRE565",
                            VehicleType = 3
                        },
                        new
                        {
                            Id = 4,
                            ArrivalTime = new DateTime(2022, 2, 3, 12, 3, 16, 99, DateTimeKind.Local).AddTicks(7111),
                            Brand = "Scania",
                            Color = "Black",
                            Model = "",
                            NoOfWheels = 8,
                            Parked = true,
                            RegNo = "MLB803",
                            VehicleType = 4
                        },
                        new
                        {
                            Id = 5,
                            ArrivalTime = new DateTime(2022, 2, 3, 12, 3, 16, 99, DateTimeKind.Local).AddTicks(7113),
                            Brand = "BMV",
                            Color = "Black",
                            Model = "",
                            NoOfWheels = 6,
                            Parked = true,
                            RegNo = "MXW413",
                            VehicleType = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

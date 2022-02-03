using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations
{
    public partial class ChangeColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vehicleType",
                table: "Vehicle",
                newName: "VehicleType");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Color", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 23, 57, 721, DateTimeKind.Local).AddTicks(1555), "Svart", 0 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Color", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 23, 57, 721, DateTimeKind.Local).AddTicks(1621), "Blå", 0 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "Color", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 23, 57, 721, DateTimeKind.Local).AddTicks(1627), "Vit", 2 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "Color", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 23, 57, 721, DateTimeKind.Local).AddTicks(1631), "Svart", 3 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "Color", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 23, 57, 721, DateTimeKind.Local).AddTicks(1635), "Svart", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleType",
                table: "Vehicle",
                newName: "vehicleType");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Color", "vehicleType" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2838), "Black", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Color", "vehicleType" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2891), "Blue", 1 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "Color", "vehicleType" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2895), "White", 3 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "Color", "vehicleType" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2897), "Black", 4 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "Color", "vehicleType" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2900), "Black", 2 });
        }
    }
}

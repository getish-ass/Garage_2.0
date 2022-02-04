using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations
{
    public partial class ChangeVehicleTypeToNotAvailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 40, 45, 424, DateTimeKind.Local).AddTicks(1596), 1 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 40, 45, 424, DateTimeKind.Local).AddTicks(1636), 1 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 40, 45, 424, DateTimeKind.Local).AddTicks(1638), 3 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 40, 45, 424, DateTimeKind.Local).AddTicks(1641), 4 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 40, 45, 424, DateTimeKind.Local).AddTicks(1643), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 27, 45, 103, DateTimeKind.Local).AddTicks(8196), 0 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 27, 45, 103, DateTimeKind.Local).AddTicks(8255), 0 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 27, 45, 103, DateTimeKind.Local).AddTicks(8260), 2 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 27, 45, 103, DateTimeKind.Local).AddTicks(8264), 3 });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "VehicleType" },
                values: new object[] { new DateTime(2022, 2, 3, 11, 27, 45, 103, DateTimeKind.Local).AddTicks(8267), 1 });
        }
    }
}

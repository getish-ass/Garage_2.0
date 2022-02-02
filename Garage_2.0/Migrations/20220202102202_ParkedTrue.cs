using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations
{
    public partial class ParkedTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2838), true });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2891), true });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2895), true });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2897), true });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 22, 1, 854, DateTimeKind.Local).AddTicks(2900), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6351), false });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6400), false });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6403), false });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6405), false });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "Parked" },
                values: new object[] { new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6407), false });
        }
    }
}

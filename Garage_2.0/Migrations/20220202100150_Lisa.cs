using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations
{
    public partial class Lisa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 1, 50, 763, DateTimeKind.Local).AddTicks(6407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9887));
        }
    }
}

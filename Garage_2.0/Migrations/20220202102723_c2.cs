using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations
{
    public partial class c2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "ArrivalTime", "Brand", "Color", "Model", "NoOfWheels", "Parked", "RegNo", "vehicleType" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3683), "Mercedes-Benz", "Black", "CX30", 4, false, "DRE065", 4 },
                    { 7, new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3686), "Scania", "Black", "Venus", 6, false, "DLB103", 4 },
                    { 8, new DateTime(2022, 2, 2, 11, 27, 22, 768, DateTimeKind.Local).AddTicks(3690), "Tesla", "White", "Zeta", 4, false, "FX0413", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 8);

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

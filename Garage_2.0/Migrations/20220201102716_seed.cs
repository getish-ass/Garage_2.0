using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage_2._0.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Vehicle_vehicleTypeId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_vehicleTypeId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "vehicleTypeId",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "vehicleType",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "ArrivalTime", "Brand", "Color", "Model", "NoOfWheels", "Parked", "RegNo", "vehicleType" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9837), "Volvo", "Black", "V60", 4, true, "FHX010", 1 },
                    { 2, new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9878), "Toyota", "Blue", "Celica Supra", 4, true, "HHS407", 1 },
                    { 3, new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9882), "Mercedes-Benz", "White", "Arocs", 6, true, "XRE565", 3 },
                    { 4, new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9884), "Scania", "Black", "", 8, true, "MLB803", 4 },
                    { 5, new DateTime(2022, 2, 1, 11, 27, 15, 974, DateTimeKind.Local).AddTicks(9887), "BMV", "Black", "", 6, true, "MXW413", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "vehicleType",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "vehicleTypeId",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_vehicleTypeId",
                table: "Vehicle",
                column: "vehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Vehicle_vehicleTypeId",
                table: "Vehicle",
                column: "vehicleTypeId",
                principalTable: "Vehicle",
                principalColumn: "Id");
        }
    }
}

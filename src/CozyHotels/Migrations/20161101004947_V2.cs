using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CozyHotels.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOrders_EventHalls_EventHallId",
                table: "EventOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Restuarants_RestuarantTable_TableId",
                table: "Restuarants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestuarantTable",
                table: "RestuarantTable");

            migrationBuilder.DropIndex(
                name: "IX_EventOrders_EventHallId",
                table: "EventOrders");

            migrationBuilder.DropColumn(
                name: "BedsSize",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "RoomType",
                table: "RoomOrders");

            migrationBuilder.DropColumn(
                name: "EventHallId",
                table: "EventOrders");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "CabOrders");

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "Rooms",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "RestuarantTable",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "RoomOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "EventOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarTypeId",
                table: "CabOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Charge",
                table: "CarTypes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CarTypes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRooms",
                table: "RoomTypes",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfBeds",
                table: "RoomTypes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomTypes",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "RoomTypes",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestuarantTables",
                table: "RestuarantTable",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOrders_RoomId",
                table: "EventOrders",
                column: "RoomId");

            migrationBuilder.AlterColumn<string>(
                name: "DishName",
                table: "Dishes",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "CarTypes",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "CarTypes",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "CarTypes",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_EventOrders_Rooms_RoomId",
                table: "EventOrders",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restuarants_RestuarantTables_TableId",
                table: "Restuarants",
                column: "TableId",
                principalTable: "RestuarantTable",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "RestuarantTable",
                newName: "RestuarantTables");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventOrders_Rooms_RoomId",
                table: "EventOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Restuarants_RestuarantTables_TableId",
                table: "Restuarants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestuarantTables",
                table: "RestuarantTables");

            migrationBuilder.DropIndex(
                name: "IX_EventOrders_RoomId",
                table: "EventOrders");

            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "RestuarantTables");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "RoomOrders");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "EventOrders");

            migrationBuilder.DropColumn(
                name: "CarTypeId",
                table: "CabOrders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Charge",
                table: "CarTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CarTypes");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "BedsSize",
                table: "RoomTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomType",
                table: "RoomOrders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventHallId",
                table: "EventOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "CabOrders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfRooms",
                table: "RoomTypes",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfBeds",
                table: "RoomTypes",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "RoomTypes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "RoomTypes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestuarantTable",
                table: "RestuarantTables",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOrders_EventHallId",
                table: "EventOrders",
                column: "EventHallId");

            migrationBuilder.AlterColumn<string>(
                name: "DishName",
                table: "Dishes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "CarTypes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "CarTypes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "CarTypes",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventOrders_EventHalls_EventHallId",
                table: "EventOrders",
                column: "EventHallId",
                principalTable: "EventHalls",
                principalColumn: "EventHallId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restuarants_RestuarantTable_TableId",
                table: "Restuarants",
                column: "TableId",
                principalTable: "RestuarantTables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "RestuarantTables",
                newName: "RestuarantTable");
        }
    }
}

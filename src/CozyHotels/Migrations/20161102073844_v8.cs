using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CozyHotels.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UniqueOrderId",
                table: "Spas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueOrderId",
                table: "Restuarants",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueOrderId",
                table: "RoomOrders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueOrderId",
                table: "FoodOrders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueOrderId",
                table: "EventOrders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueOrderId",
                table: "CabOrders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueOrderId",
                table: "Spas");

            migrationBuilder.DropColumn(
                name: "UniqueOrderId",
                table: "Restuarants");

            migrationBuilder.DropColumn(
                name: "UniqueOrderId",
                table: "RoomOrders");

            migrationBuilder.DropColumn(
                name: "UniqueOrderId",
                table: "FoodOrders");

            migrationBuilder.DropColumn(
                name: "UniqueOrderId",
                table: "EventOrders");

            migrationBuilder.DropColumn(
                name: "UniqueOrderId",
                table: "CabOrders");
        }
    }
}

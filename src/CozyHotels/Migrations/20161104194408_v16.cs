using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CozyHotels.Migrations
{
    public partial class v16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCards_Customers_CustomerId",
                table: "CustomerCards");

            migrationBuilder.DropForeignKey(
                name: "FK_CabOrders_Customers_CustomerId",
                table: "CabOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EventOrders_Customers_CustomerId",
                table: "EventOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrders_Customers_CustomerId",
                table: "FoodOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomOrders_Customers_CustomerId",
                table: "RoomOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Restuarants_Customers_CustomerId",
                table: "Restuarants");

            migrationBuilder.DropForeignKey(
                name: "FK_Spas_Customers_CustomerId",
                table: "Spas");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Spas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Restuarants",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "RoomOrders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "RoomOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "FoodOrders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "EventOrders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "CabOrders",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "CustomerCards",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Spas",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Restuarants",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "RoomOrders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "FoodOrders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "EventOrders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CabOrders",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerCards",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCards_Customers_CustomerId",
                table: "CustomerCards",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CabOrders_Customers_CustomerId",
                table: "CabOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventOrders_Customers_CustomerId",
                table: "EventOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrders_Customers_CustomerId",
                table: "FoodOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomOrders_Customers_CustomerId",
                table: "RoomOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Restuarants_Customers_CustomerId",
                table: "Restuarants",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spas_Customers_CustomerId",
                table: "Spas",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCards_Customers_CustomerId",
                table: "CustomerCards");

            migrationBuilder.DropForeignKey(
                name: "FK_CabOrders_Customers_CustomerId",
                table: "CabOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EventOrders_Customers_CustomerId",
                table: "EventOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrders_Customers_CustomerId",
                table: "FoodOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomOrders_Customers_CustomerId",
                table: "RoomOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Restuarants_Customers_CustomerId",
                table: "Restuarants");

            migrationBuilder.DropForeignKey(
                name: "FK_Spas_Customers_CustomerId",
                table: "Spas");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Spas");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Restuarants");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "RoomOrders");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "RoomOrders");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "FoodOrders");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "EventOrders");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "CabOrders");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "CustomerCards");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Spas",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Restuarants",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "RoomOrders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "FoodOrders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "EventOrders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CabOrders",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerCards",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCards_Customers_CustomerId",
                table: "CustomerCards",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CabOrders_Customers_CustomerId",
                table: "CabOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventOrders_Customers_CustomerId",
                table: "EventOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrders_Customers_CustomerId",
                table: "FoodOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomOrders_Customers_CustomerId",
                table: "RoomOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Restuarants_Customers_CustomerId",
                table: "Restuarants",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spas_Customers_CustomerId",
                table: "Spas",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

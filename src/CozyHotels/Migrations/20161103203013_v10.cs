using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CozyHotels.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_FoodOrders_OrderFoodOrderId",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_OrderFoodOrderId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "OrderFoodOrderId",
                table: "Dishes");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_DishId",
                table: "FoodOrders",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodOrders_Dishes_DishId",
                table: "FoodOrders",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "DishId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodOrders_Dishes_DishId",
                table: "FoodOrders");

            migrationBuilder.DropIndex(
                name: "IX_FoodOrders_DishId",
                table: "FoodOrders");

            migrationBuilder.AddColumn<int>(
                name: "OrderFoodOrderId",
                table: "Dishes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_OrderFoodOrderId",
                table: "Dishes",
                column: "OrderFoodOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_FoodOrders_OrderFoodOrderId",
                table: "Dishes",
                column: "OrderFoodOrderId",
                principalTable: "FoodOrders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

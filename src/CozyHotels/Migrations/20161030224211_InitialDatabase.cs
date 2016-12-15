using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CozyHotels.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    CarTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.CarTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "RestuarantTable",
                columns: table => new
                {
                    TableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsReserved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestuarantTable", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BedsSize = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Charge = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsRegularRoom = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NumberOfBeds = table.Column<int>(nullable: false),
                    NumberOfRooms = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarTypeId = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "CarTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    DishId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_FoodOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spas",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spas", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Spas_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restuarants",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    TableId = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restuarants", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Restuarants_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restuarants_RestuarantTable_TableId",
                        column: x => x.TableId,
                        principalTable: "RestuarantTable",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventHalls",
                columns: table => new
                {
                    EventHallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAvailable = table.Column<bool>(nullable: false),
                    RoomTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventHalls", x => x.EventHallId);
                    table.ForeignKey(
                        name: "FK_EventHalls_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAvailable = table.Column<bool>(nullable: false),
                    RoomTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CabOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<int>(nullable: false),
                    CarType = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    DateOfOrder = table.Column<DateTime>(nullable: false),
                    LicenseNumber = table.Column<string>(nullable: false),
                    NumberOfDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_CabOrders_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CabOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Charge = table.Column<double>(nullable: false),
                    DishName = table.Column<string>(nullable: true),
                    OrderFoodOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_Dishes_FoodOrders_OrderFoodOrderId",
                        column: x => x.OrderFoodOrderId,
                        principalTable: "FoodOrders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventOrders",
                columns: table => new
                {
                    OrderEventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Accommodation = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    DateOfArrival = table.Column<DateTime>(nullable: false),
                    DateOfDeperture = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EventHallId = table.Column<int>(nullable: false),
                    EventType = table.Column<string>(nullable: true),
                    NumberOfAttendees = table.Column<int>(nullable: false),
                    RoomTypeId = table.Column<int>(nullable: false),
                    TermsAndConditions = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventOrders", x => x.OrderEventId);
                    table.ForeignKey(
                        name: "FK_EventOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventOrders_EventHalls_EventHallId",
                        column: x => x.EventHallId,
                        principalTable: "EventHalls",
                        principalColumn: "EventHallId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    DateOfArrival = table.Column<DateTime>(nullable: false),
                    RoomId = table.Column<int>(nullable: false),
                    RoomType = table.Column<string>(nullable: true),
                    TermsAndConditions = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_RoomOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomOrders_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_OrderFoodOrderId",
                table: "Dishes",
                column: "OrderFoodOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EventHalls_RoomTypeId",
                table: "EventHalls",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CabOrders_CarId",
                table: "CabOrders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CabOrders_CustomerId",
                table: "CabOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOrders_CustomerId",
                table: "EventOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventOrders_EventHallId",
                table: "EventOrders",
                column: "EventHallId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_CustomerId",
                table: "FoodOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomOrders_CustomerId",
                table: "RoomOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomOrders_RoomId",
                table: "RoomOrders",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Restuarants_CustomerId",
                table: "Restuarants",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Restuarants_TableId",
                table: "Restuarants",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spas_CustomerId",
                table: "Spas",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "CabOrders");

            migrationBuilder.DropTable(
                name: "EventOrders");

            migrationBuilder.DropTable(
                name: "RoomOrders");

            migrationBuilder.DropTable(
                name: "Restuarants");

            migrationBuilder.DropTable(
                name: "Spas");

            migrationBuilder.DropTable(
                name: "FoodOrders");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "EventHalls");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RestuarantTable");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}

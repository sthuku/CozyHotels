using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CozyHotels.Models;

namespace CozyHotels.Migrations
{
    [DbContext(typeof(CozyHotelsContext))]
    partial class CozyHotelsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CozyHotels.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarTypeId");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired();

                    b.HasKey("CarId");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CozyHotels.Models.CarType", b =>
                {
                    b.Property<int>("CarTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<double>("Charge");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Make")
                        .IsRequired();

                    b.Property<string>("Model")
                        .IsRequired();

                    b.HasKey("CarTypeId");

                    b.ToTable("CarTypes");
                });

            modelBuilder.Entity("CozyHotels.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<bool>("Age");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CozyHotels.Models.CustomerCard", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingZip")
                        .IsRequired();

                    b.Property<int>("CVV");

                    b.Property<string>("CardNumber")
                        .IsRequired();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<string>("NameOnCard")
                        .IsRequired();

                    b.HasKey("EntryId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerCards");
                });

            modelBuilder.Entity("CozyHotels.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<double>("Charge");

                    b.Property<string>("Description");

                    b.Property<string>("DishName")
                        .IsRequired();

                    b.Property<int?>("OrderFoodOrderId");

                    b.HasKey("DishId");

                    b.HasIndex("OrderFoodOrderId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("CozyHotels.Models.EventHall", b =>
                {
                    b.Property<int>("EventHallId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAvailable");

                    b.Property<int>("RoomTypeId");

                    b.HasKey("EventHallId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("EventHalls");
                });

            modelBuilder.Entity("CozyHotels.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Charge");

                    b.Property<int>("EntryId");

                    b.Property<Guid>("ReferenceNumber");

                    b.HasKey("InvoiceId");

                    b.HasIndex("EntryId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("CozyHotels.Models.OrderCab", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarId");

                    b.Property<int>("CarTypeId");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateOfOrder");

                    b.Property<string>("LicenseNumber")
                        .IsRequired();

                    b.Property<int>("NumberOfDays");

                    b.Property<Guid>("UniqueOrderId");

                    b.HasKey("OrderId");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CabOrders");
                });

            modelBuilder.Entity("CozyHotels.Models.OrderEvent", b =>
                {
                    b.Property<int>("OrderEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Accommodation");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateOfArrival");

                    b.Property<DateTime>("DateOfDeperture");

                    b.Property<string>("Description");

                    b.Property<string>("EventType");

                    b.Property<int>("NumberOfAttendees");

                    b.Property<int>("RoomId");

                    b.Property<int>("RoomTypeId");

                    b.Property<bool>("TermsAndConditions");

                    b.Property<Guid>("UniqueOrderId");

                    b.HasKey("OrderEventId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.ToTable("EventOrders");
                });

            modelBuilder.Entity("CozyHotels.Models.OrderFood", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<int>("DishId");

                    b.Property<Guid>("UniqueOrderId");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("FoodOrders");
                });

            modelBuilder.Entity("CozyHotels.Models.OrderRoom", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateOfArrival");

                    b.Property<DateTime?>("DateOfDeperture");

                    b.Property<int>("RoomId");

                    b.Property<int>("RoomTypeId");

                    b.Property<bool>("TermsAndConditions");

                    b.Property<Guid>("UniqueOrderId");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomOrders");
                });

            modelBuilder.Entity("CozyHotels.Models.Restuarant", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Day");

                    b.Property<int>("TableId");

                    b.Property<string>("Time");

                    b.Property<Guid>("UniqueOrderId");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TableId");

                    b.ToTable("Restuarants");
                });

            modelBuilder.Entity("CozyHotels.Models.RestuarantTable", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsReserved");

                    b.Property<string>("TableName")
                        .IsRequired();

                    b.HasKey("TableId");

                    b.ToTable("RestuarantTables");
                });

            modelBuilder.Entity("CozyHotels.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("RoomName")
                        .IsRequired();

                    b.Property<int>("RoomTypeId");

                    b.HasKey("RoomId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CozyHotels.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<double>("Charge");

                    b.Property<string>("Description");

                    b.Property<bool>("IsRegularRoom");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("NumberOfBeds");

                    b.Property<int?>("NumberOfRooms");

                    b.HasKey("RoomTypeId");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("CozyHotels.Models.Spa", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Day");

                    b.Property<string>("Time");

                    b.Property<Guid>("UniqueOrderId");

                    b.HasKey("AppointmentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Spas");
                });

            modelBuilder.Entity("CozyHotels.Models.Car", b =>
                {
                    b.HasOne("CozyHotels.Models.CarType", "CarType")
                        .WithMany()
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.CustomerCard", b =>
                {
                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.Dish", b =>
                {
                    b.HasOne("CozyHotels.Models.OrderFood")
                        .WithMany("Dishes")
                        .HasForeignKey("OrderFoodOrderId");
                });

            modelBuilder.Entity("CozyHotels.Models.EventHall", b =>
                {
                    b.HasOne("CozyHotels.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.Invoice", b =>
                {
                    b.HasOne("CozyHotels.Models.CustomerCard", "CustomerCard")
                        .WithMany()
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.OrderCab", b =>
                {
                    b.HasOne("CozyHotels.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.OrderEvent", b =>
                {
                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany("OrderEvent")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CozyHotels.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.OrderFood", b =>
                {
                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.OrderRoom", b =>
                {
                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany("OrderRoom")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CozyHotels.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.Restuarant", b =>
                {
                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CozyHotels.Models.RestuarantTable", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.Room", b =>
                {
                    b.HasOne("CozyHotels.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CozyHotels.Models.Spa", b =>
                {
                    b.HasOne("CozyHotels.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

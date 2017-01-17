using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public class CozyHotelsContext:DbContext
    {
        private IConfigurationRoot _config;

        public CozyHotelsContext(IConfigurationRoot config, DbContextOptions options):base(options)
        {
            _config = config;
        }

        public DbSet<OrderRoom> RoomOrders { get; set; }
        public DbSet<OrderEvent> EventOrders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<EventHall> EventHalls { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<OrderCab> CabOrders { get; set; }
        public DbSet<OrderFood> FoodOrders { get; set; }
        public DbSet<Restuarant> Restuarants { get; set; }
        public DbSet<RestuarantTable> RestuarantTables { get; set; }
        public DbSet<Spa> Spas { get; set; }
        public DbSet<CustomerCard> CustomerCards { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:CozyHotelsContext"]);
        }
    }
}

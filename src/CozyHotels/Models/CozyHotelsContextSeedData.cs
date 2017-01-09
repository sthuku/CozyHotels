using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public class CozyHotelsContextSeedData
    {
        private CozyHotelsContext _context;

        public CozyHotelsContextSeedData(CozyHotelsContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.CarTypes.Any())
            {
                var carType = new CarType()
                {
                    Make="Honda", Model="Accord", Capacity=5, Charge=160, Description="3 Baggage, Excluding Gas"
                };
                _context.CarTypes.Add(carType);

                var roomType = new RoomType()
                {
                    Name="Standard", Capacity=2, IsRegularRoom=true, NumberOfRooms=1, NumberOfBeds=1, Charge=300, Description="One King Size Bed, including Washer and Dryer"
                };
                _context.RoomTypes.Add(roomType);

                var car = new Car()
                {
                    CarTypeId = 1, IsAvailable = true, RegistrationNumber = "CHI5858"
                };
                _context.Cars.Add(car);

                var room = new Room()
                {
                    RoomName="CH101", RoomTypeId=1
                };
                _context.Rooms.Add(room);

                var dish = new Dish()
                {
                    DishName="Salad", Category="Food", Charge=6, Description="Organic raw veggies"
                };
                _context.Dishes.Add(dish);

                var restuarantTable = new RestuarantTable()
                {
                    TableName="CRB001", IsReserved=true
                };
                _context.RestuarantTables.Add(restuarantTable);

                await _context.SaveChangesAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public class CozyHotelsRepository:ICozyHotelsRepository
    {
        private CozyHotelsContext _context;

        public CozyHotelsRepository(CozyHotelsContext context)
        {
            _context = context;
        }

        public IEnumerable<CustomerCard> GetAllCustomerCards()
        {
            return _context.CustomerCards.ToList();
        }

        public void AddCustomerCard(CustomerCard customerCard)
        {
            _context.CustomerCards.Add(customerCard);
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public IEnumerable<Dish> GetAllDishes()
        {
            return _context.Dishes.ToList();
        }

        public IEnumerable<OrderCab> GetAllCabOrders()
        {
            return _context.CabOrders.ToList();
        }

        public IEnumerable<OrderEvent> GetAllEventOrders()
        {
            return _context.EventOrders.ToList();
        }

        public IEnumerable<OrderFood> GetAllFoodOrders()
        {
            return _context.FoodOrders.ToList();
        }

        public IEnumerable<OrderRoom> GetAllRoomOrders()
        {
            return _context.RoomOrders.ToList();
        }

        public IEnumerable<Restuarant> GetAllRestuarantReservations()
        {
            return _context.Restuarants.ToList();
        }

        public IEnumerable<RestuarantTable> GetAllRestuarantTables()
        {
            return _context.RestuarantTables.ToList();
        }

        public IEnumerable<RoomType> GetAllRoomTypes()
        {
            return _context.RoomTypes.ToList();
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }

        public IEnumerable<CarType> GetAllCarTypes()
        {
            return _context.CarTypes.ToList();
        }

        public IEnumerable<Spa> GetAllSpaAppointments()
        {
            return _context.Spas.ToList();
        }

        public void AddCarType(CarType carType)
        {
            _context.CarTypes.Add(carType);
        }

        public void AddRoomType(RoomType roomType)
        {
            _context.RoomTypes.Add(roomType);
        }

        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
        }

        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void AddDish(Dish dish)
        {
            _context.Dishes.Add(dish);
        }

        public void AddCabOrder(OrderCab orderCab)
        {
            _context.CabOrders.Add(orderCab);
        }

        public void AddEventOrder(OrderEvent orderEvent)
        {
            _context.EventOrders.Add(orderEvent);
        }

        public void AddFoodOrder(OrderFood orderFood)
        {
            _context.FoodOrders.Add(orderFood);
        }

        public void AddRoomOrder(OrderRoom orderRoom)
        {
            _context.RoomOrders.Add(orderRoom);
        }

        public void AddRestuarantReservation(Restuarant restuarant)
        {
            _context.Restuarants.Add(restuarant);
        }

        public void AddRestuarantTable(RestuarantTable restuarantTable)
        {
            _context.RestuarantTables.Add(restuarantTable);
        }

        public void AddSpaAppointment(Spa spa)
        {
            _context.Spas.Add(spa);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()) > 0;
        }
    }
}

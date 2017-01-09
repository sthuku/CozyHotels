using System.Collections.Generic;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public interface ICozyHotelsRepository
    {

        IEnumerable<CarType> GetAllCarTypes();
        void AddCarType(CarType carType);
        IEnumerable<RoomType> GetAllRoomTypes();
        void AddRoomType(RoomType roomType);
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
        IEnumerable<Room> GetAllRooms();
        void AddRoom(Room room);
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
        IEnumerable<Dish> GetAllDishes();
        void AddDish(Dish dish);
        IEnumerable<OrderCab> GetAllCabOrders();
        void AddCabOrder(OrderCab orderCab);
        IEnumerable<OrderEvent> GetAllEventOrders();
        void AddEventOrder(OrderEvent orderEvent);
        IEnumerable<OrderFood> GetAllFoodOrders();
        void AddFoodOrder(OrderFood orderFood);
        IEnumerable<OrderRoom> GetAllRoomOrders();
        void AddRoomOrder(OrderRoom orderRoom);
        IEnumerable<Restuarant> GetAllRestuarantReservations();
        void AddRestuarantReservation(Restuarant restuarant);
        IEnumerable<RestuarantTable> GetAllRestuarantTables();
        void AddRestuarantTable(RestuarantTable restuarantTable);
        IEnumerable<Spa> GetAllSpaAppointments();
        IEnumerable<Invoice> GetAllInvoices();
        void AddSpaAppointment(Spa spa);
        void AddInvoice(Invoice invoice);
        IEnumerable<CustomerCard> GetAllCustomerCards();
        void AddCustomerCard(CustomerCard customerCard);
        bool SaveChanges();
    }
}
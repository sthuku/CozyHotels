using CozyHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.ViewModels
{
    public class AdminGetCustomerOrdersViewModel
    {
        private ICozyHotelsRepository _repository;
        private string _email;

        public AdminGetCustomerOrdersViewModel(ICozyHotelsRepository repository, string email)
        {
            _repository = repository;
            _email = email;
        }

        public IEnumerable<OrderRoom> RoomOrders()
        {
            return _repository.GetAllRoomOrders().Where(q => q.CustomerEmail == _email);
        }

        public IEnumerable<OrderCab> CabOrders()
        {
            return _repository.GetAllCabOrders().Where(q => q.CustomerEmail == _email);
        }

        public IEnumerable<OrderEvent> EventOrders()
        {
            return _repository.GetAllEventOrders().Where(q => q.CustomerEmail == _email);
        }

        public IEnumerable<OrderFood> FoodOrders()
        {
            return _repository.GetAllFoodOrders().Where(q => q.CustomerEmail == _email);
        }

        public IEnumerable<Restuarant> RestuarantTableReservations()
        {
            return _repository.GetAllRestuarantReservations().Where(q => q.CustomerEmail == _email);
        }

        public IEnumerable<Spa> SpaAppointments()
        {
            return _repository.GetAllSpaAppointments().Where(q => q.CustomerEmail == _email);
        }

        public Invoice Invoice(Guid id)
        {
            return _repository.GetAllInvoices().Single(q => q.ReferenceNumber == id);
        }

        public IEnumerable<CustomerCard> CustomerCards()
        {
            return _repository.GetAllCustomerCards().Where(q => q.CustomerEmail == _email);
        }

        public Car Car(int id)
        {
            return _repository.GetAllCars().Single(q => q.CarId == id);
        }

        public CarType CarType(int id)
        {
            return _repository.GetAllCarTypes().Single(q => q.CarTypeId == id);
        }

        public Dish Dish(int id)
        { 
            return _repository.GetAllDishes().Single(q => q.DishId == id);
        }
    }
}

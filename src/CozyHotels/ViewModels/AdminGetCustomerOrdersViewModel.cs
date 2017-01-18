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
        private int _id;

        public AdminGetCustomerOrdersViewModel(ICozyHotelsRepository repository, int id)
        {
            _repository = repository;
            _id = id;
        }

        public IEnumerable<OrderRoom> RoomOrders()
        {
            return _repository.GetAllRoomOrders().Where(q => q.CustomerId == _id);
        }

        public IEnumerable<OrderCab> CabOrders()
        {
            return _repository.GetAllCabOrders().Where(q => q.CustomerId == _id);
        }

        public IEnumerable<OrderEvent> EventOrders()
        {
            return _repository.GetAllEventOrders().Where(q => q.CustomerId == _id);
        }

        public IEnumerable<OrderFood> FoodOrders()
        {
            return _repository.GetAllFoodOrders().Where(q => q.CustomerId == _id);
        }

        public IEnumerable<Restuarant> RestuarantTableReservations()
        {
            return _repository.GetAllRestuarantReservations().Where(q => q.CustomerId == _id);
        }

        public IEnumerable<Spa> SpaAppointments()
        {
            return _repository.GetAllSpaAppointments().Where(q => q.CustomerId == _id);
        }

        public Invoice Invoice(Guid id)
        {
            return _repository.GetAllInvoices().Single(q => q.ReferenceNumber == id);
        }

        public IEnumerable<CustomerCard> CustomerCards()
        {
            return _repository.GetAllCustomerCards().Where(q => q.CustomerId == _id);
        }

        public Car Car(int id)
        {
            return _repository.GetAllCars().Single(q => q.CarId == id);
        }

        public CarType CarType(int id)
        {
            return _repository.GetAllCarTypes().Single(q => q.CarTypeId == id);
        }
    }
}

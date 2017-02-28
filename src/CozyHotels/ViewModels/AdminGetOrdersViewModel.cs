using CozyHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.ViewModels
{
    public class AdminGetOrdersViewModel
    {
        private ICozyHotelsRepository _repository;

        public AdminGetOrdersViewModel(ICozyHotelsRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<OrderCab> GetCabOrders()
        {
            return _repository.GetAllCabOrders();
        }

        public IEnumerable<OrderRoom> GetRoomOrders()
        {
            return _repository.GetAllRoomOrders();
        }

        public IEnumerable<OrderEvent> GetEventOrders()
        {
            return _repository.GetAllEventOrders();
        }

        public IEnumerable<OrderFood> GetFoodOrders()
        {
            return _repository.GetAllFoodOrders();
        }

        public IEnumerable<Restuarant> GetRestuarantReservations()
        {
            return _repository.GetAllRestuarantReservations();
        }

        public IEnumerable<Spa> GetSpaAppointments()
        {
            return _repository.GetAllSpaAppointments();
        }

        public Invoice Invoice(Guid id)
        {
            return _repository.GetAllInvoices().Single(q => q.ReferenceNumber == id);
        }
    }
}

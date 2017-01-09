using CozyHotels.Models;
using CozyHotels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Controllers.Web
{
    public class ServiceController:Controller
    {
        private CozyHotelsContext _context;
        private Room _room;
        private ICozyHotelsRepository _repository;
        private Car _car;

        public ServiceController(CozyHotelsContext context, ICozyHotelsRepository repository)
        {

            _car = new Car();
            _room = new Room();
            _context = context;
            _repository = repository;
        }

        public IActionResult GetRoom()
        {
            /*var customer = new Customer();
            var roomType = new List<RoomType>();
            var orderRoom = new OrderRoom();
            ServiceGetRoomViewModel model = new ServiceGetRoomViewModel() {
                Customer = customer, RoomTypes=roomType, OrderRoom=orderRoom
            };*/

            ViewBag.RoomTypes = _room.RoomTypes(_repository.GetAllRoomTypes());
            return View(new ServiceGetRoomViewModel());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult GetRoom(ServiceGetRoomViewModel roomModel)
        {
            if (roomModel.OrderRoom.RoomTypeId == -1)
               ModelState.AddModelError("OrderRoom.RoomTypeId", "Please select the Room Type");

            if (roomModel.Customer.Age == false)
                ModelState.AddModelError("Customer.Age", "Sorry you must not be below 21 years old");

            if (roomModel.OrderRoom.TermsAndConditions == false)
                ModelState.AddModelError("OrderRoom.TermsAndConditions", "We need to see your Id");


            if (ModelState.IsValid)
            {
                var check = _repository.GetAllCustomers()
                    .Where(q => q.Email == roomModel.Customer.Email);
                if (check.Count() > 0)
                    ViewBag.GetRoom = "Email is already taken! \nIf you ever booked a room or event, you can log in!";
                else
                {
                    _repository.AddCustomer(roomModel.Customer);
                    if (_repository.SaveChanges())
                    {
                        var roomOrders = _repository.GetAllRoomOrders()
                            .Where(q =>
                        (q.DateOfArrival >= roomModel.OrderRoom.DateOfArrival &&
                        q.DateOfArrival <= roomModel.OrderRoom.DateOfDeperture) ||
                        (q.DateOfDeperture >= roomModel.OrderRoom.DateOfArrival &&
                        q.DateOfDeperture <= q.DateOfDeperture));
                        var rooms = _repository.GetAllRooms();

                        foreach (var order in roomOrders)
                        {
                            rooms = rooms.Where(q => q.RoomId != order.RoomId);
                        }


                        if (rooms.Count() > 0)
                        {
                            roomModel.OrderRoom.RoomId = rooms.First().RoomId;
                            roomModel.OrderRoom.CustomerEmail = roomModel.Customer.Email;
                            roomModel.OrderRoom.UniqueOrderId = Guid.NewGuid();
                            _repository.AddRoomOrder(roomModel.OrderRoom);
                            if (_repository.SaveChanges())
                            {
                                ViewBag.GetRoom = "Thank you!";
                                ModelState.Clear();
                            }
                            else
                                ViewBag.GetRoom = "Oops! Could not place order";
                        }
                        else
                        {
                            ViewBag.GetRoom = "Rooms are not available";
                        }

                    }
                    else
                        ViewBag.GetRoom = "Oops! Could not Save data";
                }
            }

            ViewBag.RoomTypes = _room.RoomTypes(_repository.GetAllRoomTypes());
            return View(new ServiceGetRoomViewModel());
            
        }

        public IActionResult RestuarantAndBar()
        {
            ViewBag.Timings = new List<SelectListItem>
            {
                new SelectListItem {Value="-1",Text="Time" },
                new SelectListItem {Value="EarlyMorning",Text="Early Morning" },
                new SelectListItem {Value="Morning",Text="Morning" },
                new SelectListItem {Value="Noon",Text="Noon" },
                new SelectListItem {Value="Afternoon",Text="Afternoon" },
                new SelectListItem {Value="Evening",Text="Evening" },
                new SelectListItem {Value="AfterNine",Text="After nine" },
                new SelectListItem {Value="Midnight",Text="Midnight" }
            };
            return View();
        }

        [HttpPost]
        public IActionResult RestuarantAndBar(Restuarant model)
        {
            if (model.Time == "-1")
                ModelState.AddModelError("Time", "Tell us when do want this Service");

            if (ModelState.IsValid)
            {
                ViewBag.SpaAppointment = "Thanks";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult GetCab()
        {
            ViewBag.Cars = _car.CarTypes(_repository.GetAllCarTypes()); 
            return View();
        }

        [HttpPost]
        public IActionResult GetCab(OrderCab carModel)
        {
            if (carModel.CarTypeId == -1)
              ModelState.AddModelError("OrderCab.CarTypeId", "Please select the Room Type");
            if (ModelState.IsValid)
            {
                
                var check = _repository.GetAllCustomers().Single(q => q.Email == carModel.CustomerEmail);

                if (check.Password == carModel.Password)
                {
                    var cabOrders = _repository.GetAllCabOrders()
                            .Where(q =>
                        (q.DateOfOrder >= carModel.DateOfOrder &&
                        q.DateOfOrder <= carModel.DateOfReturn) ||
                        (q.DateOfReturn >= carModel.DateOfOrder &&
                        q.DateOfReturn <= q.DateOfReturn) && q.CarTypeId == carModel.CarTypeId);
                    var cars = _repository.GetAllCars();

                    foreach (var order in cabOrders)
                    {
                        cars = cars.Where(q => q.CarId != order.CarId);
                    }

                    if (cars.Count() > 0)
                    {
                        carModel.CarId = cars.First().CarId;
                        carModel.UniqueOrderId = Guid.NewGuid();
                        _repository.AddCabOrder(carModel);
                        if (_repository.SaveChanges())
                        {
                            ViewBag.GetCab = "Please get keys at the front desk for " + cars.First().RegistrationNumber;
                            ModelState.Clear();
                        }
                    }
                    else
                    {
                        ViewBag.GetCab = "Sorry selected cars are not available at given dates"; 
                    }
                }
                else
                    ViewBag.GetCab = "Invalid Email or Password";

            }

            ViewBag.Cars = _car.CarTypes(_repository.GetAllCarTypes());
            return View();
        }

        public IActionResult Events()
        {
            var customer = new Customer();
            var orderEvent = new OrderEvent();
            ServiceEventsViewModel model = new ServiceEventsViewModel() {
                Customer=customer, OrderEvent=orderEvent
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Events(ServiceEventsViewModel model)
        {
            if (model.OrderEvent.EventType == "-1")
                ModelState.AddModelError("OrderEvent.EventType", "Please select the Event Type");

            if (model.Customer.Age == false)
                ModelState.AddModelError("Customer.Age", "Sorry you must not be below 21 years old");

            if (model.OrderEvent.TermsAndConditions == false)
                ModelState.AddModelError("OrderEvent.TermsAndConditions", "We need to see your Id");


            if (ModelState.IsValid)
            {
                ViewBag.EventRequestStatus = "Thanks!";
                ModelState.Clear();
            }

            var customer = new Customer();
            var even = new EventType();
            var orderEvent = new OrderEvent();
            ServiceEventsViewModel model2 = new ServiceEventsViewModel()
            {
                Customer = customer,
                OrderEvent=orderEvent
            };
            return View(model2);
        }

        public IActionResult SpaAndFitness()
        {

            ViewBag.Timings = new List<SelectListItem>
            {
                new SelectListItem {Value="-1",Text="Time" },
                new SelectListItem {Value="EarlyMorning",Text="Early Morning" },
                new SelectListItem {Value="Morning",Text="Morning" },
                new SelectListItem {Value="Noon",Text="Noon" },
                new SelectListItem {Value="Afternoon",Text="Afternoon" },
                new SelectListItem {Value="Evening",Text="Evening" },
                new SelectListItem {Value="AfterNine",Text="After nine" },
                new SelectListItem {Value="Midnight",Text="Midnight" }
            };
            return View();
        }

        [HttpPost]
        public IActionResult SpaAndFitness(Spa model)
        {
            if (model.Time == "-1")
                ModelState.AddModelError("Time", "Tell us when do want this service");

            if (ModelState.IsValid)
            {
                ViewBag.SpaAppointment = "Thanks";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult DishesAndDrinks()
        {
            return View();
        }
    }
}

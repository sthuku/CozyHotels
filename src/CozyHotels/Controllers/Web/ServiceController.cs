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

        public ServiceController(CozyHotelsContext context)
        {
            _context = context;
        }

        public IActionResult GetRoom()
        {
            var customer = new Customer();
            var roomType = new List<RoomType>();
            var orderRoom = new OrderRoom();
            ServiceGetRoomViewModel model = new ServiceGetRoomViewModel() {
                Customer = customer, RoomTypes=roomType, OrderRoom=orderRoom
            };

            return View(model);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult GetRoom(ServiceGetRoomViewModel model)
        {
            if (model.OrderRoom.RoomTypeId == -1)
               ModelState.AddModelError("OrderRoom.RoomTypeId", "Please select the Room Type");

            if (model.Customer.Age == false)
                ModelState.AddModelError("Customer.Age", "Sorry you must not be below 21 years old");

            if (model.OrderRoom.TermsAndConditions == false)
                ModelState.AddModelError("OrderRoom.TermsAndConditions", "We need to see your Id");


            if (ModelState.IsValid)
            {
                ViewBag.RoomRequestStatus = "Thanks!";
                ModelState.Clear();
            }

            var customer = new Customer();
            var roomType = new List<RoomType>();
            var orderRoom = new OrderRoom();
            ServiceGetRoomViewModel model2 = new ServiceGetRoomViewModel()
            {
                Customer = customer,
                RoomTypes = roomType,
                OrderRoom = orderRoom
            };
            return View(model2);
            
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
            var orderCab = new OrderCab();
            var carTypes = new List<CarType>();
            var model = new ServiceGetCabViewModel() {
                OrderCab=orderCab,CarTypes=carTypes
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult GetCab(ServiceGetCabViewModel model)
        {
            if (model.OrderCab.CarTypeId == -1)
              ModelState.AddModelError("OrderCab.CarTypeId", "Please select the Room Type");


            if (ModelState.IsValid)
            {
                ViewBag.CarRequest = "Thanks!";
                ModelState.Clear();
            }

            var orderCab = new OrderCab();
            var carTypes = new List<CarType>();
            var model2 = new ServiceGetCabViewModel()
            {
                OrderCab = orderCab,
                CarTypes = carTypes
            };
            return View(model2);
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
            var even = new EventHall();
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

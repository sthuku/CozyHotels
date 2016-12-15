using CozyHotels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Controllers
{
    public class AdminController:Controller
    {
        private Car _car;
        private List<CarType> _carTypes;
        private Room _room;
        private List<RoomType> _roomTypes;
        private CozyHotelsContext _context;

        public AdminController(CozyHotelsContext context)
        {
            _car = new Car();
            _carTypes = new List<CarType>();
            _room = new Room();
            _roomTypes = new List<RoomType>();
           _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCarType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCarType(CarType carType)
        {
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.CarTypes.Add(carType);
                    db.SaveChanges();
                    ModelState.Clear();
                }
            }
            return View();
        }

        public IActionResult AddCar()
        {
            ViewBag.CarTypes = _car.CarTypes(_carTypes);
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (car.CarTypeId == -1)
                ModelState.AddModelError("CarTypeId", "Select a Car");
            if (ModelState.IsValid)
            {
                ViewBag.AddCar = "Thanks!";
                ModelState.Clear();
            }

            ViewBag.CarTypes = _car.CarTypes(_carTypes);
            return View();
        }

        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDish(Dish dish)
        {
            if (dish.Category == "-1")
                ModelState.AddModelError("Category", "Select Category");
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
        }

        public IActionResult AddRoomType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoomType(RoomType roomType)
        {
            if(roomType.IsRegularRoom == false)
            {
                if (roomType.NumberOfRooms == null)
                    ModelState.AddModelError("NumberOfRooms", "Required");
                if (roomType.NumberOfBeds == null)
                    ModelState.AddModelError("NumberOfBeds", "Required");
            }else
            {
                roomType.NumberOfBeds = null;
                roomType.NumberOfRooms = null;
            }

            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult AddRoom()
        {
            ViewBag.RoomTypes = _room.RoomTypes(_roomTypes);
            return View();
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            ViewBag.RoomTypes = _room.RoomTypes(_roomTypes);
            if (room.RoomTypeId == -1)
                ModelState.AddModelError("RoomTypeId", "Select Room Type");
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult AddRestuarantTable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRestuarantTable(RestuarantTable table)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }

            return View();
        }
    }
}

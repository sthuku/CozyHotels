using CozyHotels.Models;
using CozyHotels.ViewModels;
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
        private Room _room; 
        private CozyHotelsContext _context;
        private ICozyHotelsRepository _repository;

        public AdminController(CozyHotelsContext context, ICozyHotelsRepository repository)
        {
            _car = new Car();
            _room = new Room();
           _context = context;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCarTypes()
        {
            return View(_repository.GetAllCarTypes());
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
                var check = _repository.GetAllCarTypes()
                    .Where(q => q.Make == carType.Make && q.Model == carType.Model);
                if (check.Count() > 0)
                    ViewBag.CarType = "Car Model already exists!";
                else {
                    _repository.AddCarType(carType);
                    if (_repository.SaveChanges())
                    {
                        ViewBag.CarType = "Successfull!";
                        ModelState.Clear();
                    }
                    else
                        ViewBag.CarType = "Oops! Could not save data";
                }
            }
            return View();
        }

        public IActionResult GetCars()
        {
            return View(new AdminGetCarsViewModel(_repository.GetAllCars(), _repository.GetAllCarTypes()));
        }
        public IActionResult AddCar()
        {
            ViewBag.CarTypes = _car.CarTypes(_repository.GetAllCarTypes());
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (car.CarTypeId == -1)
                ModelState.AddModelError("CarTypeId", "Select a Car");
            if (ModelState.IsValid)
            {
                var check = _repository.GetAllCars()
                    .Where(q => q.RegistrationNumber == car.RegistrationNumber);
                if(check.Count() > 0)
                    ViewBag.AddCar = "Seems like a car exists with entered registration numer";
                else
                {
                    car.IsAvailable = true;
                    _repository.AddCar(car);
                    if (_repository.SaveChanges())
                    {
                        ViewBag.AddCar = "Successfull!";
                        ModelState.Clear();
                    }
                    else
                        ViewBag.AddCar = "Oops! Could not save data";
                }
                
            }

            ViewBag.CarTypes = _car.CarTypes(_repository.GetAllCarTypes());
            return View();
        }

        public IActionResult GetDishes()
        {
            return View(_repository.GetAllDishes());
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
                var check = _repository.GetAllDishes()
                    .Where(q => q.DishName== dish.DishName && q.Category == dish.Category);

                if (check.Count() > 0)
                    ViewBag.AddDish = "This dish already exists";
                else
                {
                    _repository.AddDish(dish);
                    if (_repository.SaveChanges())
                    {
                        ViewBag.AddDish = "Successfull!";
                        ModelState.Clear();
                    }
                    else
                        ViewBag.AddDish = "Oops! could not be Added";
                }
            }
            return View();
        }

        public IActionResult GetRoomTypes()
        {
            return View(_repository.GetAllRoomTypes());
        }

        public IActionResult AddRoomType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoomType(RoomType roomType)
        {
            if(roomType.IsRegularRoom == true)
            {
                if (roomType.NumberOfRooms == null)
                    ModelState.AddModelError("NumberOfRooms", "Required");
                if (roomType.NumberOfBeds == null)
                    ModelState.AddModelError("NumberOfBeds", "Required");
            }

            if (ModelState.IsValid)
            {
                var check = _repository.GetAllRoomTypes().Where(q => q.Name == roomType.Name);
                if (check.Count() > 0)
                    ViewBag.AddRoomType = "This Room already Exists";
                else
                {
                    _repository.AddRoomType(roomType);
                    if (_repository.SaveChanges())
                    {
                        ViewBag.AddRoomType = "Successfull!";
                        ModelState.Clear();
                    }
                    else
                        ViewBag.AddRoomType = "Oops! Could not add new room type";
                }
            }

            return View();
        }

        public IActionResult GetRooms()
        {
            return View(new AdminGetRoomsViewModel(_repository.GetAllRooms(), _repository.GetAllRoomTypes()));
        }

        public IActionResult AddRoom()
        {
            ViewBag.RoomTypes = _room.RoomTypes(_repository.GetAllRoomTypes());
            return View();
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            ViewBag.RoomTypes = _room.RoomTypes(_repository.GetAllRoomTypes());
            if (room.RoomTypeId == -1)
                ModelState.AddModelError("RoomTypeId", "Select Room Type");
            if (ModelState.IsValid)
            {
                var check = _repository.GetAllRooms().Where(q => q.RoomName == room.RoomName);
                if (check.Count() > 0)
                    ViewBag.AddRoom = "A Room named "+ room.RoomName + " already exists!";
                else
                {
                    room.IsAvailable = true;
                    _repository.AddRoom(room);
                    if (_repository.SaveChanges())
                    {
                        ViewBag.AddRoom = "Successfull!";
                        ModelState.Clear();
                    }
                    else
                        ViewBag.AddRoom = "Oops! Could not add room";
                }
                
            }

            return View();
        }


        public IActionResult GetRestuarantTables()
        {
            return View(_repository.GetAllRestuarantTables());
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
                var check = _repository.GetAllRestuarantTables().Where(q => q.TableName == table.TableName);
                if (check.Count() > 0)
                    ViewBag.AddRestuarantTable = "This Table already exists!";
                else
                {
                    table.IsReserved = false;
                    _repository.AddRestuarantTable(table);
                    if (_repository.SaveChanges())
                    {
                        ViewBag.AddRestuarantTable = "Successfull!";
                        ModelState.Clear();
                    }
                    else
                        ViewBag.AddRestuarantTable = "Oops! Could not be added";
                }
               
            }

            return View();
        }

        public IActionResult GetCustomers()
        {
            return View(_repository.GetAllCustomers());
        }

        public IActionResult GetCustomerOrders(int id)
        {
            return View(new AdminGetCustomerOrdersViewModel(_repository, id));
        }

        public IActionResult GetCabOrders()
        {
            return View(new AdminGetOrdersViewModel(_repository));
        }

        public IActionResult GetRoomOrders()
        {
            return View(new AdminGetOrdersViewModel(_repository));
        }

        public IActionResult GetEventOrders()
        {
            return View(new AdminGetOrdersViewModel(_repository));
        }

        public IActionResult GetFoodOrders()
        {
            return View(new AdminGetOrdersViewModel(_repository));
        }
    }
}

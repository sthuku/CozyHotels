using CozyHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.ViewModels
{
    public class AdminGetCarsViewModel
    {
        private IEnumerable<Car> _cars;
        private IEnumerable<CarType> _carTypes;

        public AdminGetCarsViewModel(IEnumerable<Car> cars, IEnumerable<CarType> carTypes)
        {
            _cars = cars;
            _carTypes = carTypes;
        }
        
        public IEnumerable<Car> Cars()
        {
            return _cars;
        }

        public CarType GetCarType(int id)
        {
            return _carTypes.Single(q => q.CarTypeId == id);
        }
    }
}

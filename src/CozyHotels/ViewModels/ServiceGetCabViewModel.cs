
using CozyHotels.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CozyHotels.ViewModels
{
    public class ServiceGetCabViewModel
    {
        public Customer Customer { get; set; }
        public OrderCab OrderCab { get; set; }
        public List<CarType> CarTypes;

    }
}

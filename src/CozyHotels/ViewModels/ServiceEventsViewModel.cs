using CozyHotels.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CozyHotels.ViewModels
{
    public class ServiceEventsViewModel
    {
        public Customer Customer { get; set; }
        public OrderEvent OrderEvent { get; set; }

        public List<SelectListItem> EventTypes()
        {
            SelectListItem item = new SelectListItem();
            List<SelectListItem> items = new List<SelectListItem>()
            { new SelectListItem { Value = "-1", Text = "Type of Event" }};
            return items;
        }
    }
}

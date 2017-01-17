
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

        public List<SelectListItem> Cars()
        {
            SelectListItem item = new SelectListItem();
            List<SelectListItem> items = new List<SelectListItem>()
            { new SelectListItem { Value = "-1", Text = "Select the type of Room" }};
            foreach (var listItem in CarTypes)
            {
                item.Text = listItem.Make + " " + listItem.Model;
                item.Value = listItem.CarTypeId.ToString();
                items.Add(item);
            }

            return items;
        }

    }
}

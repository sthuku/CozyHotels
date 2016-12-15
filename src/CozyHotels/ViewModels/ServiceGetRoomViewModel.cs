using CozyHotels.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CozyHotels.ViewModels
{
    public class ServiceGetRoomViewModel
    {
        public Customer Customer { get; set; }
        public List<RoomType> RoomTypes { get; set; }
        public OrderRoom OrderRoom { get; set; }


        public List<SelectListItem> Rooms()
        {
            SelectListItem item = new SelectListItem();
            List<SelectListItem> items = new List<SelectListItem>()
            { new SelectListItem { Value = "-1", Text = "Select the type of Room" }};
            foreach (var listItem in RoomTypes)
            {
                item.Text = listItem.Name;
                item.Value = listItem.RoomTypeId.ToString();
                items.Add(item);
            }

            return items;
        }

    }
}

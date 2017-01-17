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
            List<SelectListItem> items = new List<SelectListItem>()
            { new SelectListItem { Value = "-1", Text = "Select the type of Room" }};
            foreach (var listItem in RoomTypes)
            {
                SelectListItem item = new SelectListItem();
                item.Text = listItem.Name;
                item.Value = listItem.RoomTypeId.ToString();
                items.Add(item);
            }
            return items;
        }

    }
}

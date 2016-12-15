using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public int RoomTypeId { get; set; }
        [Required]
        public string RoomName { get; set; }
        public bool IsAvailable { get; set; }
        public RoomType RoomType { get; set; }

        public List<SelectListItem> RoomTypes(List<RoomType> roomTypes)
        {
            SelectListItem item = new SelectListItem();
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem {Value="-1", Text = "Room Type" }
            };

            foreach (var listItems in roomTypes)
            {
                item.Value = listItems.RoomTypeId.ToString();
                item.Text = listItems.Name;
                items.Add(item);
            }

            return items;
        }
    }
}

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

        public List<SelectListItem> RoomTypes(IEnumerable<RoomType> roomTypes)
        {
            
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem {Value="-1", Text = "Room Type" }
            };

            foreach (var listItems in roomTypes)
            {
                SelectListItem item = new SelectListItem();
                item.Value = listItems.RoomTypeId.ToString();
                item.Text = listItems.Name;
                items.Add(item);
            }

            return items;
        }
    }
}

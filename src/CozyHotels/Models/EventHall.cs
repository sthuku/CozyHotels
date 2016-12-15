using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class EventHall
    {
        [Key]
        public int EventHallId { get; set; }
        public int RoomTypeId { get; set; }
        public bool IsAvailable { get; set; }

        public RoomType RoomType { get; set; }
    }
}

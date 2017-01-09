using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }

        public string Type { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class OrderEvent
    {
        [Key]
        public int OrderEventId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public int RoomTypeId { get; set; }
        public string EventType { get; set; }
        [Required]
        public int NumberOfAttendees { get; set; }
        public bool Accommodation { get; set; }
        public string Description { get; set; }


        [Required(ErrorMessage = "Date of Arrival is required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfArrival { get; set; }

        [Required(ErrorMessage = "Date of Deperture is required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfDeperture { get; set; }
        public Boolean TermsAndConditions { get; set; }
        public Customer Customer { get; set; }
        public Room Room { get; set; }
    }
}

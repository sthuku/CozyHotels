using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class OrderRoom
    {
        [Key]
        public int OrderId { get; set; }
        
        public string CustomerEmail { get; set; }
        public int RoomId { get; set; }
        public int RoomTypeId { get; set; }

        public int MyProperty { get; set; }

        [Required(ErrorMessage = "Date of Arrival is required")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfArrival { get; set; }

        [Required(ErrorMessage = "Date of Departure is required")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfDeperture { get; set; }
        public Boolean TermsAndConditions { get; set; }

        public Guid UniqueOrderId { get; set; }
        public Customer Customer { get; set; }
        public Room Room { get; set; }
    }
}

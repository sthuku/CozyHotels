using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class OrderCab
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        [ScaffoldColumn(false)]
        public string Password { get; set; }
        public int CarId { get; set; }

        [Required(ErrorMessage = "Date of Order is required")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfOrder { get; set; }

        [Required(ErrorMessage = "Date of Return is required")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfReturn { get; set; }
        public int CarTypeId { get; set; }
   

        public Guid UniqueOrderId { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
    }
}

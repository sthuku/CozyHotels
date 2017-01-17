using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class OrderCab
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        [Required]
        public DateTime DateOfOrder { get; set; }
        public int CarTypeId { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        public int NumberOfDays { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
    }
}

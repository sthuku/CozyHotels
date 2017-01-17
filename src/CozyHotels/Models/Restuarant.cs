using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class Restuarant
    {
        [Key]
        public int ReservationId { get; set; }
        public int TableId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime Day { get; set; }
        public string Time { get; set; }
        public RestuarantTable Table { get; set; }
        public Customer Customer { get; set; }
    }
}

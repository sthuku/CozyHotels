using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class Spa
    {
        [Key]
        public int AppointmentId { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public DateTime Day { get; set; }
        public String Time { get; set; }

        public Guid UniqueOrderId { get; set; }
        public Customer Customer { get; set; }
    }
}

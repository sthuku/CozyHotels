using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class OrderFood
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        public int DishId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public Guid UniqueOrderId { get; set; }
        public Customer Customer { get; set; }
        public Dish Dish { get; set; }
    }
}

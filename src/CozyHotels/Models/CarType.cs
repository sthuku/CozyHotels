using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public class CarType
    {
        [Key]
        public int CarTypeId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public double Charge { get; set; }
        [Required]
        public string Description { get; set; }
    }
}

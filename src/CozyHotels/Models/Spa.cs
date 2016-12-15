﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class Spa
    {
        [Key]
        public int AppointmentId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime Day { get; set; }
        public String Time { get; set; }

        public Customer Customer { get; set; }
    }
}
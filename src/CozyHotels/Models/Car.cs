using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public int CarTypeId { get; set; }
        //[Required]
        //public string CarTypeName { get; set; }
        public bool IsAvailable { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        public CarType CarType { get; set; }

        public List<SelectListItem> CarTypes(IEnumerable<CarType> carTypes)
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem {Value="-1", Text = "Car Model" }
            };

            foreach (var listItems in carTypes)
            {
                SelectListItem item = new SelectListItem();
                item.Value = listItems.CarTypeId.ToString();
                item.Text = listItems.Make + " " + listItems.Model;
                items.Add(item);
            }

            return items;
        }
    }
}

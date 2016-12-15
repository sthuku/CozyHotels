using System.ComponentModel.DataAnnotations;


namespace CozyHotels.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string DishName { get; set; }
        public string Category { get; set; }
        [Required]
        public double Charge { get; set; }
        public string Description { get; set; }
    }
}

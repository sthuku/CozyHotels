using System.ComponentModel.DataAnnotations;


namespace CozyHotels.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsRegularRoom { get; set; }
        public string Description { get; set; }
        [Required]
        public int Capacity { get; set; }
        public int? NumberOfBeds { get; set; }
        public int? NumberOfRooms { get; set; }
        //[Required]
        //public string BedsSize { get; set; }
        [Required]
        public double Charge { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class RestuarantTable
    {
        [Key]
        public int TableId { get; set; }
        [Required]
        public string TableName { get; set; }
        public bool IsReserved { get; set; }
    }
}

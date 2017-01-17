using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public class CustomerCard
    {
        [Key]
        public int EntryId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [CreditCard]
        public string CardNumber { get; set; }
        [Required]
        public string NameOnCard { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public int CVV { get; set; }
        [Required]
        public string BillingZip { get; set; }

        public Customer Customer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyHotels.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public double Charge { get; set; }
        public int EntryId { get; set; }
        public Guid ReferenceNumber { get; set; }
        public CustomerCard CustomerCard { get; set; }
    }
}

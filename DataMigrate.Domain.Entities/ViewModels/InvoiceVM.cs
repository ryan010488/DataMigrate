using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DataMigrate.Domain.Entities.Models;

namespace DataMigrate.Domain.Entities.ViewModels
{
    public class InvoiceVM
    {

        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Note { get; set; }
        [Required]
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public List<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}

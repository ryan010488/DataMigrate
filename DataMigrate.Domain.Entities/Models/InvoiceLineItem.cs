using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMigrate.Domain.Entities.Models
{
    public class InvoiceLineItem
    {
        [Key]
        public int InvoiceLineItemId { get; set; }
        [Required]
        public string InvoiceLineItemIdentifier { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Description { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitAmount { get; set; }
        [Required]
        public decimal LineAmount { get; set; }
        public int PatientId { get; set; }
        public int TreatmentId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMigrate.Domain.Entities.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Required]
        public string InvoiceIdentifier { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Note { get; set; }
        [Required]
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal Discount { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public int PatientId { get; set; }

        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}

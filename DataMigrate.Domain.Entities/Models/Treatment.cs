using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataMigrate.Domain.Entities.Models
{
    public class Treatment
    {
        [Key]
        public int TreatmentId { get; set; }
        [Required]
        public string TreatmentIdentifier { get; set; } = Guid.NewGuid().ToString();
        public DateTime? CompleteDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ItemCode { get; set; }
        public string? Tooth { get; set; }
        public string? Surface { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Fee { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        [Required]
        public bool IsVoided { get; set; }
        public int PatientId { get; set; }
        public int InvoiceId { get; set; }
    }
}

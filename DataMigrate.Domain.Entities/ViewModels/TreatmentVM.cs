using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DataMigrate.Domain.Entities.Models;

namespace DataMigrate.Domain.Entities.ViewModels
{
    public class TreatmentVM
    {
        public string CompleteDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ItemCode { get; set; }
        public string Tooth { get; set; }
        public string Surface { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Fee { get; set; }
        [Required]
        public string IsPaid { get; set; }
        public string PatientId { get; set; }
        public List<InvoiceVM> Invoices { get; set; }
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool HasError { get; set; }
    }
}

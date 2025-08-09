using System.ComponentModel.DataAnnotations;

namespace DataMigrate.Domain.Entities.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string PatientIdentifier { get; set; }
        public string? PatientNo { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string? Middlename { get; set; }
        public string? PreferredName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Title { get; set; }
        public string? Sex { get; set; }
        public string? Email { get; set; }
        public string? HomePhone { get; set; }
        public string? Mobile { get; set; }
        public string? Occupation { get; set; }
        public string? CompanyName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Suburb { get; set; }
        public string? Postcode { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}

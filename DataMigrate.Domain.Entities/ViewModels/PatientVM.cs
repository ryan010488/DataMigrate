using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DataMigrate.Domain.Entities.Models;

namespace DataMigrate.Domain.Entities.ViewModels
{
    public class PatientVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Identifier { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool HasError { get; set; }
    }
}

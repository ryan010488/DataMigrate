using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Entities.ViewModels;
using DataMigrate.Domain.Interfaces.Repositories;
using DataMigrate.Domain.Interfaces.Services;

namespace DataMigrate.Infrastructure.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<List<PatientVM>> GetAll()
        {
            var model = await _patientRepository.GetAll();
            var result = new List<PatientVM>();

            if (model.Count > 0)
            {
                for (int i = 0; i < model.Count; i++)
                {
                    var item = model[i];

                    result.Add(new PatientVM
                    {
                        Id = item.PatientId,
                        Identifier = item.PatientIdentifier,
                        Firstname = item.Firstname,
                        Lastname = item.Lastname,
                    });
                }
            }

            return result;
        }

        public async Task<List<PatientVM>> Post(List<PatientVM> model)
        {
            var list = new List<Patient>();

            for (int i = 0; i < model.Count; i++)
            {
                var item = model[i];

                if (item.ErrorMessage.Count > 0) continue;

                var newPatient = new Patient
                {
                    PatientIdentifier = model[i].Identifier,
                    Firstname = model[i].Firstname,
                    Lastname = model[i].Lastname,
                    Middlename = model[i].Middlename,
                    Sex = model[i].Gender,
                    Email = model[i].Email,
                    HomePhone = model[i].HomePhone,
                    Mobile = model[i].Mobile,
                    AddressLine1 = model[i].Street,
                    Suburb = model[i].Suburb,
                    State = model[i].State,
                    Postcode = model[i].Postcode,
                };

                if (!string.IsNullOrEmpty(model[i].DateOfBirth))
                    newPatient.DateOfBirth = DateTime.Parse(model[i].DateOfBirth);

                list.Add(newPatient);
            }

            await _patientRepository.ImportBulk(list);

            model.ForEach(m =>
            {
                m.Id = list.FirstOrDefault(a => a.Firstname == m.Firstname && a.Lastname == m.Lastname).PatientId;
            });

            return model;
        }

        public List<PatientVM> ReadCsvFile(string filePath)
        {
            var result = new List<PatientVM>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Count(); i++)
                {
                    if (i == 0) continue;

                    string line = lines[i];
                    // Handle potential empty lines
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(','); // Split by comma

                        var patient = new PatientVM();

                        patient.Identifier = IsValid(values[0].Trim(), "Identifier", typeof(string), patient);
                        patient.Firstname = IsValid(values[1].Trim(), "First Name", typeof(string), patient);
                        patient.Lastname = IsValid(values[2].Trim(), "Last Name", typeof(string), patient);
                        patient.DateOfBirth = IsValid(values[3].Trim(), "Last Name", typeof(DateTime), patient);
                        patient.Gender = IsValid(values[4].Trim(), "Gender", typeof(string), patient);
                        patient.Email = IsValid(values[5].Trim(), "Email", typeof(string), patient);
                        patient.Mobile = IsValid(values[6].Trim(), "Mobile", typeof(string), patient);
                        patient.HomePhone = IsValid(values[7].Trim(), "Home Phone", typeof(string), patient);
                        patient.Street = IsValid(values[8].Trim(), "Address Line 1", typeof(string), patient);
                        patient.Suburb = IsValid(values[9].Trim(), "Suburb", typeof(string), patient);
                        patient.State = IsValid(values[10].Trim(), "State", typeof(string), patient);
                        patient.Postcode = IsValid(values[11].Trim(), "Post code", typeof(string), patient);
                        patient.HasError = patient.ErrorMessage.Count > 0;

                        result.Add(patient);
                    }
                }
                Console.WriteLine("CSV file read successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
            }

            return result.OrderByDescending(m => m.ErrorMessage.Count > 0).ToList();
        }

        private string IsValid(string value, string name, Type type, PatientVM patient)
        {
            if (string.IsNullOrEmpty(value))
            {
                patient.ErrorMessage.Add($"The '{name}' field is required to have a value.");
            }
            else
            {
                if (type == typeof(DateTime))
                {
                    if (!DateTime.TryParse(value, out DateTime resultDate))
                    {
                        patient.ErrorMessage.Add($"The '{name}' field is not a valid Date/Time.");
                    }
                }
            }

            return value;
        }

    }
}

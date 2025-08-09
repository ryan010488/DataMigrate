using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Entities.ViewModels;

namespace DataMigrate.Domain.Interfaces.Services
{
    public interface IPatientService
    {
        Task<List<PatientVM>> GetAll();

        Task<List<PatientVM>> Post(List<PatientVM> model);

        List<PatientVM> ReadCsvFile(string filePath);
    }
}

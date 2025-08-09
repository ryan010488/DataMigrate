using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Entities.ViewModels;

namespace DataMigrate.Domain.Interfaces.Services
{
    public interface ITreatmentService
    {
        Task<List<TreatmentVM>> Post(List<TreatmentVM> model, List<PatientVM> patients);

        List<TreatmentVM> ReadCsvFile(string filePath);
    }
}

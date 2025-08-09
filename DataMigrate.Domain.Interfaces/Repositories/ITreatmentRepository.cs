using DataMigrate.Domain.Entities.Models;

namespace DataMigrate.Domain.Interfaces.Repositories
{
    public interface ITreatmentRepository
    {

        Task ImportBulk(List<Treatment> model);

    }
}

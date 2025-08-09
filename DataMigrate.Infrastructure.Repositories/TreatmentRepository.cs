using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Interfaces.Repositories;
using FiberStatus.Domain.Entities.Data;

namespace FiberStatus.Infrastructure.Repositories
{
    public class TreatmentRepository : Repository<Treatment>, ITreatmentRepository
    {

        public TreatmentRepository(AppDbContext db) : base(db)
        {
        }

        public async Task ImportBulk(List<Treatment> model)
        {
            try
            {
                AddRange(model);

                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

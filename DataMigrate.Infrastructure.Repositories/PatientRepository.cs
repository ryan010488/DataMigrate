using System.Net;
using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Interfaces;
using DataMigrate.Domain.Interfaces.Repositories;
using FiberStatus.Domain.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FiberStatus.Infrastructure.Repositories
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {

        public PatientRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<List<Patient>> GetAll()
        {
            var model = await DbSet.ToListAsync();

            return model;
        }

        public async Task ImportBulk(List<Patient> model)
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

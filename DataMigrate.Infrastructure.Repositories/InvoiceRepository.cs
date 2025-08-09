using System.Net;
using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Interfaces;
using DataMigrate.Domain.Interfaces.Repositories;
using FiberStatus.Domain.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FiberStatus.Infrastructure.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {

        public InvoiceRepository(AppDbContext db) : base(db)
        {

        }

        public async Task ImportBulk(List<Invoice> model)
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

        public async Task<int> GetLastInvoiceNo()
        {
            try
            {
                var model = await DbSet.OrderByDescending(m => m.InvoiceId).FirstOrDefaultAsync();

                return model == null ? 0 : model.InvoiceNo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

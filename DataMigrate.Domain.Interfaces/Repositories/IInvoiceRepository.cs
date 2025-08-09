using DataMigrate.Domain.Entities.Models;

namespace DataMigrate.Domain.Interfaces.Repositories
{
    public interface IInvoiceRepository
    {

        Task ImportBulk(List<Invoice> model);

        Task<int> GetLastInvoiceNo();

    }
}

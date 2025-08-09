//using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataMigrate.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {

        IQueryable<T> Query();

        void Add(T entity);

        void AddRange(IEnumerable<T> entity);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entity);

        //IDbContextTransaction BeginTransaction();

        void SaveChanges();

        Task SaveChangesAsync();

        void Remove(T entity);

    }
}

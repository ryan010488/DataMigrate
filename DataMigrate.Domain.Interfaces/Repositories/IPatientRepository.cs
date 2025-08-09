using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataMigrate.Domain.Entities.Models;
using FiberStatus.Domain.Entities.Data;

namespace DataMigrate.Domain.Interfaces.Repositories
{
    public interface IPatientRepository
    {

        Task<List<Patient>> GetAll();
        Task ImportBulk(List<Patient> model);

    }
}

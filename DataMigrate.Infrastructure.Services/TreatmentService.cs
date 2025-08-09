using DataMigrate.Domain.Entities.Models;
using DataMigrate.Domain.Entities.ViewModels;
using DataMigrate.Domain.Interfaces.Repositories;
using DataMigrate.Domain.Interfaces.Services;

namespace DataMigrate.Infrastructure.Services
{
    public class TreatmentService : ITreatmentService
    {
        private ITreatmentRepository _treatmentRepository;
        private IInvoiceRepository _invoiceRepository;

        public TreatmentService(ITreatmentRepository treatmentRepository, 
            IInvoiceRepository invoiceRepository)
        {
            _treatmentRepository = treatmentRepository;
            _invoiceRepository = invoiceRepository;
        }

        public async Task<List<TreatmentVM>> Post(List<TreatmentVM> model, List<PatientVM> patients)
        {
            try
            {
                var list = new List<Treatment>();

                for (int i = 0; i < model.Count; i++)
                {
                    var item = model[i];

                    if (item.ErrorMessage.Count > 0) continue;

                    var patient = patients.FirstOrDefault(m => m.Identifier == model[i].PatientId);

                    if (patient == null) continue;

                    var newModel = new Treatment
                    {
                        Description = model[i].Description,
                        ItemCode = model[i].ItemCode,
                        Tooth = model[i].Tooth,
                        Surface = model[i].Surface,
                        CompleteDate = Convert.ToDateTime(model[i].CompleteDate),
                        Price = Convert.ToDecimal(model[i].Price),
                        Fee = Convert.ToDecimal(model[i].Fee),
                        IsPaid = Convert.ToBoolean(model[i].IsPaid.ToLower() == "yes"),
                        PatientId = Convert.ToInt32(patient.Id),
                    };

                    if (!string.IsNullOrEmpty(model[i].CompleteDate))
                        newModel.CompleteDate = DateTime.Parse(model[i].CompleteDate);

                    list.Add(newModel);
                }

                await _treatmentRepository.ImportBulk(list);

                var lastInvoiceNo = await _invoiceRepository.GetLastInvoiceNo();
                var invoiceList = new List<Invoice>();
                var dates = list.Select(obj => obj.CompleteDate).Distinct().ToList();

                foreach (var date in dates)
                {
                    lastInvoiceNo += 1;
                    var newInvoice = new Invoice
                    {
                        InvoiceDate = date,
                        InvoiceNo = lastInvoiceNo,
                        InvoiceLineItems = new List<InvoiceLineItem>()
                    };

                    var sameDateList = list.Where(m => m.CompleteDate == date).ToList();

                    foreach (var item in sameDateList)
                    {
                        var newLineItem = new InvoiceLineItem
                        {
                            Description = item.Description,
                            ItemCode = item.ItemCode,
                            UnitAmount = item.Price,
                            LineAmount = item.Price + item.Fee,
                            PatientId = item.PatientId,
                            TreatmentId = item.TreatmentId,
                        };

                        newInvoice.InvoiceLineItems.Add(newLineItem);
                    }

                    newInvoice.Total = sameDateList.Sum(m => m.Price + m.Fee);
                    newInvoice.Paid = sameDateList
                        .Where(m => m.IsPaid)
                        .Sum(m => m.Price + m.Fee);

                    invoiceList.Add(newInvoice);
                }

                await _invoiceRepository.ImportBulk(invoiceList);

                return model;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TreatmentVM> ReadCsvFile(string filePath)
        {
            var result = new List<TreatmentVM>();
            
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

                        var model = new TreatmentVM();

                        model.PatientId = IsValid(values[1].Trim(), "Patient Id", typeof(string), model);
                        model.ItemCode = IsValid(values[3].Trim(), "Item Code", typeof(string), model);
                        model.Description = IsValid(values[4].Trim(), "Description", typeof(string), model);
                        model.Price = IsValid(values[5].Trim(), "Price", typeof(string), model);
                        model.Fee = IsValid(values[6].Trim(), "Fee", typeof(string), model);
                        model.CompleteDate = IsValid(values[7].Trim(), "Date", typeof(DateTime), model);
                        model.IsPaid = IsValid(values[8].Trim(), "Paid", typeof(bool), model);
                        model.Tooth = values[9].Trim();
                        model.Surface = values[10].Trim();
                        model.HasError = model.ErrorMessage.Count > 0;

                        result.Add(model);
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

        private string IsValid(string value, string name, Type type, TreatmentVM model)
        {
            if (string.IsNullOrEmpty(value))
            {
                model.ErrorMessage.Add($"The '{name}' field is required to have a value.");
            }
            else
            {
                if (type == typeof(DateTime))
                {
                    if (!DateTime.TryParse(value, out DateTime resultDate))
                    {
                        model.ErrorMessage.Add($"The '{name}' field is not a valid Date/Time.");
                    }
                }
                else if (type == typeof(bool))
                {
                    if (value.ToLower() == "yes") value = "true";
                    else if (value.ToLower() == "no") value = "false";
                    else if (!bool.TryParse(value, out bool resultBoolean))
                    {
                        model.ErrorMessage.Add($"The '{name}' field is not a valid True/False.");
                    }
                }
            }

            return value;
        }

    }
}

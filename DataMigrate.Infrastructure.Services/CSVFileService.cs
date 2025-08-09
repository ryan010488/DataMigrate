namespace DataMigrate.Infrastructure.Services
{
    public class CSVFileService
    {

        public static List<string[]> ReadCsvFile(string filePath)
        {
            List<string[]> rows = new List<string[]>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    // Handle potential empty lines
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(','); // Split by comma
                        rows.Add(values);
                    }
                }
                Console.WriteLine("CSV file read successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
            }
            return rows;
        }

    }
}

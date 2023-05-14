using System;

namespace Core
{
    public class CsvHelper
    {
        /// <summary>
        /// Retrieves all the records from the provided CSV data and returns them as an enumerable collection of Gallery objects.
        /// </summary>
        /// <param name="csv">The CSV data stream.</param>
        /// <returns>A list of Gallery objects.</returns>
        public static List<IDatabase> DatabaseRecords<IDatabase>(Stream csv)
        {
            using var reader = new StreamReader(csv);
            using var file = new CsvReader(reader, CultureInfo.InvariantCulture);
            return file.GetRecords<IDatabase>().ToList();
        }
    }
}


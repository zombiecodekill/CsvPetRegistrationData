using System.Collections.Generic;

namespace PetReportCsvExporter
{
    public class CsvReport
    {
        private IFileWriter _fileWriter;

        public CsvReport(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void PrintPetEntries(IEnumerable<PetEntry> petEntry, string filename)
        {
            var entries = PetEntries.ConvertPetEntriesToCommaDelimitedStrings(petEntry);
            _fileWriter.WriteAllLines(filename, entries);
        }
    }
}

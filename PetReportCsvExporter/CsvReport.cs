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

        public void PrintPetEntries(List<PetEntryModel> petEntry, string filename)
        {
            var entries = CommaDelimitedStringBuilder.ConvertPetEntriesToCommaDelimitedStrings(petEntry);
            _fileWriter.WriteAllLines(filename, entries);
        }
    }
}

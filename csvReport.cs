using System.Collections.Generic;

namespace PetReporting
{
    public class CsvReport
    {
        private PetEntries _petEntries;
        private IFileWriter _fileWriter;

        public CsvReport(PetEntries petEntries, IFileWriter fileWriter)
        {
            _petEntries = petEntries;
            _fileWriter = fileWriter;
        }

        public void printPetEntries(IEnumerable<PetEntry> petEntry, string filename)
        {
            var entries = _petEntries.ConvertPetEntriesToCommaDelimitedStrings(petEntry);
            _fileWriter.WriteAllLines(filename, entries);
        }
    }
}

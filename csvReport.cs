using System;
using System.Collections.Generic;
using System.IO;

namespace PetReporting
{
    public class CsvReport
    {
        private PetEntries _petEntries;
        public CsvReport(PetEntries petEntries)
        {
            _petEntries = petEntries;
        }

        public void printReport(IEnumerable<PetEntry> petEntry, string filename)
        {
            var entries = _petEntries.ConvertPetEntriesToCommaDelimitedStrings(petEntry);
            File.WriteAllLines(filename, entries.ToArray());
        }
    }
}

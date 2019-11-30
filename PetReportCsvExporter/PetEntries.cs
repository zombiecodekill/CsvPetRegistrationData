using System.Collections.Generic;

namespace PetReportCsvExporter
{
    public static class PetEntries
    {
        public static List<string> ConvertPetEntriesToCommaDelimitedStrings(IEnumerable<PetEntry> petEntries)
        {
            List<string> entries = new List<string>
            {
                "Species,Owners name,Date Joined Practice,Number Of Visits"
            };
            foreach (var p in petEntries)
            {
                var entry = p.Species + ","
                           + p.Owner.Fullname + ","
                           + p.DateJoinedPractice + ","
                           + p.NumberOfVisits;

                entries.Add(entry);
            }
            return entries;
        }
    }
}
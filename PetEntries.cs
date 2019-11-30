using System.Collections.Generic;

namespace PetReporting
{
    public static class PetEntries
    {
        public static List<string> ConvertPetEntriesToCommaDelimitedStrings(IEnumerable<PetEntry> petEntries)
        {
            List<string> entries = new List<string>();
            entries.Add("Owners name,Date Joined Practice,Number Of Visits,Number of Lives");
            foreach (var p in petEntries)
            {
                var entry = p.Owner.Fullname + "," 
                           + p.DateJoinedPractice + "," 
                           + p.NumberOfVisits + "," 
                           + p.NumberOfLives;
               
                entries.Add(entry);
            }
            return entries;
        }
    }
}
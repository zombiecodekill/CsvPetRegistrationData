using System;

namespace PetReportCsvExporter
{
    /* 
     * This class uses Reflection to get the property names and the order that these properties are 
     * declared affects the order in which they appear on the CSV file
     */
    public class PetEntryModel
    {
        public string Species { get; set; }
        public string OwnerName { get; set; }
        public DateTime DateJoinedPractice { get; set; }
        public uint NumberOfVisits { get; set; }

    }
}

namespace PetReportCsvExporter
{
    public class PetEntry
    {
        public Owner Owner { get; set; }

        public string Species { get; set; }
        public string PetName { get; set; }

        public uint NumberOfVisits;

        public System.DateTime DateJoinedPractice;

    }
}

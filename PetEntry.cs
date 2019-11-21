namespace PetReporting
{
    public class PetEntry
    {
        public Owner Owner { get; set; }

        public string PetName { get; set; }

        public int? NumberOfLives;

        public uint NumberOfVisits;

        public System.DateTime DateJoinedPractice;

        public PetEntry()
        {

        }
    }
}

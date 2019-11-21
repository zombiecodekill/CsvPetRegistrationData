namespace PetReporting
{
    public class OwnerFactory
    {
        public Owner Create(string firstName, string lastName)
        {
            return new Owner
            {
                Firstname = firstName,
                Lastname = lastName,
                Fullname = firstName + " " + lastName
            };
        }
    }
}

using System;
using System.Collections.Generic;

namespace PetReportCsvExporter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veterinary Practice Pet Registration CSV Exporter");
            Console.WriteLine("Press any key to export data to a CSV file");

            Console.ReadKey();

            // This application is just a very simple demo
            // In a real word application this data might be read in from a web service or manually entered etc.

            var JimJordan = new OwnerFactory().Create("Jim", "Jordan");
            var TonySmith = new OwnerFactory().Create("Tony", "Smith");
            var SteveRoberts = new OwnerFactory().Create("Steve", "Roberts");
            var DavidMatthews = new OwnerFactory().Create("David", "Matthews");

            var pets = new List<PetEntry>()
            {
                new PetEntry() {
                    Owner = JimJordan,
                    Species = Species.Dog.ToString(),
                    NumberOfVisits = 5,
                    DateJoinedPractice = new DateTime(2019, 11, 21)
                },
                new PetEntry() {
                    Owner = TonySmith,
                    Species = Species.Cat.ToString(),
                    NumberOfVisits = 10,
                    DateJoinedPractice = new DateTime(1985, 7, 13)
                },
                new PetEntry() {
                    Owner = SteveRoberts,
                    Species = Species.Rabbit.ToString(),
                    NumberOfVisits = 20,
                    DateJoinedPractice = new DateTime(2002, 5, 6)
                },

                new PetEntry() {
                    Owner = DavidMatthews,
                    Species = Species.Hamster.ToString(),
                    NumberOfVisits = 15,
                    DateJoinedPractice = new DateTime(2004, 2, 9)
                }
            };

            new CsvReport(new FileWriter()).PrintPetEntries(pets, "petRegistrationDetails.csv");

            Console.WriteLine("CSV file created");
        }
    }
}

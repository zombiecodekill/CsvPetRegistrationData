using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PetReportCsvExporter.Tests
{
    [TestFixture]
    public class PetReportingTests
    {
        [Test]
        public void BuildsCommaDelimitedStringForHeadingsAndEachPetEntry()
        {
            // Arrange
            var JimJordan = new OwnerFactory().Create("Jim", "Jordan");
            var TonySmith = new OwnerFactory().Create("Tony", "Smith");
            var SteveRoberts = new OwnerFactory().Create("Steve", "Roberts");

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
                    Species = Species.Dog.ToString(),
                    NumberOfVisits = 10,
                    DateJoinedPractice = new DateTime(1985, 7, 13)
                },
                new PetEntry() {
                    Owner = SteveRoberts,
                    Species = Species.Cat.ToString(),
                    NumberOfVisits = 20,
                    DateJoinedPractice = new DateTime(2002, 5, 6)
                }
            };

            // Act
            var result = PetEntries.ConvertPetEntriesToCommaDelimitedStrings(pets);

            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0], Is.EqualTo("Species,Owners name,Date Joined Practice,Number Of Visits"));
            Assert.That(result[1], Is.EqualTo("Dog,Jim Jordan,21/11/2019 00:00:00,5"));
            Assert.That(result[2], Is.EqualTo("Dog,Tony Smith,13/07/1985 00:00:00,10"));
            Assert.That(result[3], Is.EqualTo("Cat,Steve Roberts,06/05/2002 00:00:00,20"));
        }
    }
}
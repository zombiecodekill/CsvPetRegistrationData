using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PetReporting.Tests
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
                    NumberOfVisits = 5, 
                    DateJoinedPractice = new DateTime(2019, 11, 21)
                },
                new PetEntry() { 
                    Owner = TonySmith, 
                    NumberOfVisits = 10, 
                    DateJoinedPractice = new DateTime(1985, 7, 13)
                },
                new PetEntry() {
                    Owner = SteveRoberts,
                    NumberOfVisits = 20, 
                    DateJoinedPractice = new DateTime(2002, 5, 6), 
                    NumberOfLives = 9 
                }
            };

            // Act
            var result = new PetEntries().ConvertPetEntriesToCommaDelimitedStrings(pets);

            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0], Is.EqualTo("Owners name,Date Joined Practice,Number Of Visits,Number of Lives"));
            Assert.That(result[1], Is.EqualTo("Jim Jordan,21/11/2019 00:00:00,5,"));
            Assert.That(result[2], Is.EqualTo("Tony Smith,13/07/1985 00:00:00,10,"));
            Assert.That(result[3], Is.EqualTo("Steve Roberts,06/05/2002 00:00:00,20,9"));
        }
    }
}
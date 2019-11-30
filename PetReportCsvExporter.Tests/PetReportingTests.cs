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

            var pets = new List<PetEntryModel>()
            {
                new PetEntryModel() {
                    OwnerName = "Jim Jordan",
                    Species = Species.Dog.ToString(),
                    NumberOfVisits = 5,
                    DateJoinedPractice = new DateTime(2019, 11, 21)
                },
                new PetEntryModel() {
                    OwnerName = "Tony Smith",
                    Species = Species.Dog.ToString(),
                    NumberOfVisits = 10,
                    DateJoinedPractice = new DateTime(1985, 7, 13)
                },
                new PetEntryModel() {
                    OwnerName = "Steve Roberts",
                    Species = Species.Cat.ToString(),
                    NumberOfVisits = 20,
                    DateJoinedPractice = new DateTime(2002, 5, 6)
                }
            };

            // Act
            var result = CommaDelimitedStringBuilder.ConvertPetEntriesToCommaDelimitedStrings(pets);

            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0], Is.EqualTo("Species,OwnerName,DateJoinedPractice,NumberOfVisits"));
            Assert.That(result[1], Is.EqualTo("Dog,Jim Jordan,21/11/2019 00:00:00,5"));
            Assert.That(result[2], Is.EqualTo("Dog,Tony Smith,13/07/1985 00:00:00,10"));
            Assert.That(result[3], Is.EqualTo("Cat,Steve Roberts,06/05/2002 00:00:00,20"));
        }
    }
}
using NUnit.Framework;
using System.Collections.Generic;
using NSubstitute;

namespace PetReporting.Tests
{
    [TestFixture]
    public class CsvReportTests
    {
        private CsvReport _target;
        private PetEntries _petEntries;

        [SetUp]
        public void Init()
        {
            _petEntries = Substitute.For<PetEntries>();
            _target = new CsvReport(_petEntries);
        }

        [Test]
        public void CsvReportCallsConvertPetEntriesToCommaDelimitedStrings()
        {
            // Arrange
            var entries = new List<PetEntry>();

            // Act
            _target.printReport(entries, "csvReport.csv");

            // Assert
            _petEntries.Received().ConvertPetEntriesToCommaDelimitedStrings(entries);
        }
    }
}

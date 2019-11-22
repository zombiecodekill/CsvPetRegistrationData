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
        private IFileWriter _fileWriter;
        private List<string> _dummyData;

        [SetUp]
        public void Init()
        {
            _dummyData = new List<string>() { "Tony Smith,13/07/1985 00:00:00,10" };

            _petEntries = Substitute.For<PetEntries>();
            _petEntries.ConvertPetEntriesToCommaDelimitedStrings(Arg.Any<IEnumerable<PetEntry>>())
                .Returns(_dummyData);

            _fileWriter = Substitute.For<IFileWriter>();
            _target = new CsvReport(_petEntries, _fileWriter);
        }

        [Test]
        public void printPetEntriesCallsFileWriter()
        {
            // Arrange
            var entries = new List<PetEntry>();

            // Act
            _target.printPetEntries(entries, "petRegistrationDetails.csv");

            // Assert
            _fileWriter.Received().WriteAllLines("petRegistrationDetails.csv", _dummyData);
        }
    }
}

using NUnit.Framework;
using System.Collections.Generic;
using NSubstitute;
namespace PetReporting.Tests
{
    [TestFixture]
    public class CsvReportTests
    {
        private CsvReport _target;
        private IFileWriter _fileWriter;

        [SetUp]
        public void Init()
        {
            _fileWriter = Substitute.For<IFileWriter>();
            _target = new CsvReport(_fileWriter);
        }

        [Test]
        public void PrintPetEntriesCallsFileWriter()
        {
            // Arrange
            var entries = new List<PetEntry>();

            // Act
            _target.PrintPetEntries(entries, "petRegistrationDetails.csv");

            // Assert
            _fileWriter.Received().WriteAllLines("petRegistrationDetails.csv", Arg.Any<List<string>>());
        }
    }
}

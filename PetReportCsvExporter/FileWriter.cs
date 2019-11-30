using System.Collections.Generic;
using System.IO;

namespace PetReportCsvExporter
{
    public class FileWriter : IFileWriter
    {
        public void WriteAllLines(string filename, List<string> csvStrings)
        {
            File.WriteAllLines(filename, csvStrings.ToArray());
        }
    }
}

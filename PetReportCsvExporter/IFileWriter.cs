using System.Collections.Generic;

namespace PetReportCsvExporter
{
    public interface IFileWriter
    {
        void WriteAllLines(string filename, List<string> csvStrings);
    }
}

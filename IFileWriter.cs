using System.Collections.Generic;

namespace PetReporting
{
    public interface IFileWriter
    {
        void WriteAllLines(string filename, List<string> csvStrings);
    }
}

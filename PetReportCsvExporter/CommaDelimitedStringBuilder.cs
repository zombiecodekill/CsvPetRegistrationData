using System.Collections.Generic;
using System.Reflection;

namespace PetReportCsvExporter
{
    public static class CommaDelimitedStringBuilder
    {
        public static PropertyInfo[] GetPropertyInfo(object model)
        {
            return model.GetType().GetProperties();
        }

        public static List<string> GetPropertyNames(PropertyInfo[] propertyInfos)
        {
            List<string> propertyNames = new List<string>();
            foreach (var p in propertyInfos)
            {
                propertyNames.Add(p.Name);
            }
            return propertyNames;
        }

        public static string BuildHeadings(List<string> propertyNames)
        {
            string headings = "";

            foreach(var property in propertyNames)
            {
                headings += property + ",";
            }
            return headings[0..^1];
        }

        public static List<string> ConvertPetEntriesToCommaDelimitedStrings(IEnumerable<PetEntryModel> petEntries)
        {
            var propertyInfos = GetPropertyInfo(new PetEntryModel());
            var propertyNames = GetPropertyNames(propertyInfos);

            string headings = BuildHeadings(propertyNames);
            List<string> entries = new List<string>
            {
                headings
            };            

            foreach (var p in petEntries)
            {
                IEnumerable<PropertyInfo> props = p.GetType().GetRuntimeProperties();

                string dataRow="";
                foreach(var prop in props)
                {
                    dataRow += prop.GetValue(p) + ",";
                }
                dataRow = dataRow[0..^1];
                entries.Add(dataRow);
            }
            return entries;
        }
    }
}
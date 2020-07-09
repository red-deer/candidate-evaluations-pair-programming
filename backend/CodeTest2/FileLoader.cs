using CsvHelper;
using System;
using System.Globalization;
using System.IO;

namespace CodeTest
{
    public class FileLoader
    {
        public string GetAssetContent(string fileName)
        {
            var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", fileName);

            // TODO: new CsvReader(reader, CultureInfo.InvariantCulture)

            return File.ReadAllText(fullPath);
        }
    }
}

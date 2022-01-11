using ReadCsv.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ReadCsv
{
    class PriceFileMenager
    {
        private readonly string _path;

        private List<Price> _prices = new List<Price>();

        public PriceFileMenager(string path)
        {
            _path = path;
        }

        public void FindAllValues()
        {
            var lines = File.ReadAllLines(_path);
            foreach (var line in lines)
            {
                string[] values = line.Split(";");
                var price = new Price(values[0], values[1]);
                price.CalculateValue();
                _prices.Add(price);

            }
        }

        public void SaveValues()
        {
            var folderPath = Path.GetDirectoryName(_path);

            var genereateFilePath = $@"{folderPath}\generate.csv";

            var priceToCsv = _prices.Select(e => e.ToString()).ToList();

            File.WriteAllLines(genereateFilePath, priceToCsv);
        }
    }
}

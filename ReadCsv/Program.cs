using ReadCsv.Models;
using System;

namespace ReadCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                return;
            }

            var readFile = new PriceFileMenager(args[0]);
            readFile.FindAllValues();

            readFile.SaveValues();
        } 
    }
}

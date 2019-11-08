using System;
using System.Collections.Generic;

namespace CSVReaderNestedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Repos\CsvReaderList\CountryPopulations.csv";

            Reader csvreader = new Reader(filepath);

            List<Country> countries = csvreader.ReadAllCountries();
            

            foreach(Country country in countries)
            {
                Console.WriteLine($"{Formatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}

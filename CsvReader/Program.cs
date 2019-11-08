using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVReaderNestedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\Repos\CSVReaderNestedLists\CountryPopulations.csv";

            Reader csvreader = new Reader(filepath);

            Dictionary<string,List<Country>> countries = csvreader.ReadAllCountries();
            foreach (string region in countries.Keys)
            {
                Console.WriteLine(region);
            }

            Console.Write("Which of the above regions do you want?");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                {
                    Console.WriteLine($"{Formatter.FormatPopulation(country.Population).PadLeft(15)}: { country.Name}");
                }         
            }
            else
            Console.WriteLine("That is not a valid region");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class City
    {
        private string? CityName { get; set; }
        private string? CountryName { get; set; }
        private string? CountryCode { get; set; }
        private int? Amount { get; set; }

        public string[] Districts { get; set; }
        public City() {
            CityName = "Empty";
            CountryName = "Empty";
            CountryCode = "Empty";
            Amount = 0;
            Districts = ["Empty"];
        }
        public City(string cityName)
        {
            CityName = cityName;
        }

        public City(string cityName, string countryName) : this(cityName)
        {
            CityName = cityName;
            CountryName = countryName;
        }

        public City(string cityName, string countryName, string countryCode) : this(cityName, countryName)
        {
            CityName = cityName;
            CountryName = countryName;
            CountryCode = countryCode;
        }

        public City(string cityName, string countryName, string countryCode, int amount) : this(cityName, countryName, countryCode)
        {
            CityName = cityName;
            CountryName = countryName;
            CountryCode = countryCode;
            Amount = amount;
        }

        public City(string cityName, string countryName, string countryCode, int amount, string[] districts) : this(cityName, countryName, countryCode, amount)
        {
            CityName = cityName;
            CountryName = countryName;
            CountryCode = countryCode;
            Amount = amount;
            Districts = districts;
        }

        public void Input()
        {
            Console.Write("Enter a city name: ");
            CityName = Console.ReadLine();

            Console.Write("Enter a country name: ");
            CountryName = Console.ReadLine();

            Console.Write("Enter a country code: ");
            CountryCode = Console.ReadLine();

            Console.Write("Enter a population: ");
            Amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a districts(by spaces): ");
            Districts = Console.ReadLine().Split(' ');
        }
        
        public void Print()
        {
            Console.WriteLine($"\nCity name: {CityName}");
            Console.WriteLine($"Country name: {CountryName}");
            Console.WriteLine($"Country code: {CountryCode}");
            Console.WriteLine($"Amount of peoples: {Amount}");
            Console.WriteLine("Districts: ");
            foreach(string distr in Districts)
            {
                Console.Write(distr + " ");
            }
        }


    }
}

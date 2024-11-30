using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class City
    {
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public int? Amount { get; set; }

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

        public override string ToString()
        {
            return $"City name: {CityName}\n" +
                $"Country name: {CountryName}\n" +
                $"Country number code: {CountryCode}\n" +
                $"Amount of people: {Amount}\n" +
                $"Districts: {String.Join(", ", Districts)}";
        }


    }
}

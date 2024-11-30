using Classes_Methods.Entities;
using System.ComponentModel;

namespace Classes_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {



            City city = new City(cityName: "Vinnytsia",
                countryName: "Ukraine",
                countryCode: "+380", 
                amount: 2000, 
                districts: ["Vyshen'ka","Center","Slavyanka"]);
           
            Console.Write(city);




        }

    }
}

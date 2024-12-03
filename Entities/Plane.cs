using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class Plane
    {
        private string Name { get; set; }
        private string CreatorName { get; set; }
        private int Year { get; set; }
        private string Type { get; set; }


        public Plane()
        {
            Name = "NaN";
            CreatorName = "NaN";
            Year = 0;
            Type = "Nan";
        }
        public Plane(string name, string creatorName, int year, string type)
        {
            Name = name;
            CreatorName = creatorName;
            Year = year;
            Type = type;
        }

        public void Input()
        {
            Console.WriteLine("Enter a name of plane");
            Name = Console.ReadLine();

            Console.WriteLine("Enter a creator name of plane");
            CreatorName = Console.ReadLine();

            Console.WriteLine("Enter a year");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a type of plane");
            Type = Console.ReadLine();
        }

        public void Input(string name,string creatorName,int year, string type)
        {
            this.Name = name;
            this.CreatorName = creatorName;
            this.Year = year;
            this.Type = type;
        }

        public void Print()
        {
            Console.WriteLine($"\nPlane info:\n" +
                $"Name: {Name}\n" +
                $"Creator name: {CreatorName}\n" +
                $"Year: {Year}\n" +
                $"Type: {Type}");
        }


    }
}

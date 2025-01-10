using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class Journal
    {
        private string Year { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string ContactPhone { get; set; }
        private string Email { get; set; }

        public Journal()
        {
            Year = "NaN";
            Name = "NaN";
            Description = "NaN";
            ContactPhone = "+3800000000";
            Email = "NaN@gmail.com";
        }
        public Journal(string year, string name, string description, string contactPhone, string email)
        {
            Year = year;
            Name = name;
            Description = description;
            ContactPhone = contactPhone;
            Email = email;
        }

        public void Input()
        {
            Console.WriteLine("Enter a name of hournal: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter an year: ");
            Year = Console.ReadLine();

            Console.WriteLine("Enter a description:");
            Description = Console.ReadLine();

            Console.WriteLine("Enter an contact phone:");
            ContactPhone = Console.ReadLine();

            Console.WriteLine("Enter an email:");
            Email = Console.ReadLine();
        }

        public void Input(string year, string name, string description, string contactPhone,string email)
        {
            this.Name = name;
            this.Year = year;
            this.Description = description;
            this.ContactPhone= contactPhone;
            this.Email = email;
        }

        public void Print()
        {
            Console.WriteLine($"\nJournal info:\n" +
                $"Name: {Name}\n" +
                $"Year: {Year}\n" +
                $"Description: {Description}\n" +
                $"Contact Phone: {ContactPhone}\n" +
                $"Email: {Email}");
        }
    }
}

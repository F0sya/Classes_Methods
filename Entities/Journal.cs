using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class Shop
    {
        private string Address { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string ContactPhone { get; set; }
        private string Email { get; set; }

        public Shop()
        {
            Address = "NaN";
            Name = "NaN";
            Description = "NaN";
            ContactPhone = "+3800000000";
            Email = "NaN@gmail.com";
        }
        public Shop(string address, string name, string description, string contactPhone, string email)
        {
            Address = address;
            Name = name;
            Description = description;
            ContactPhone = contactPhone;
            Email = email;
        }

        public void Input()
        {
            Console.WriteLine("Enter a name of shop: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter an address of shop: ");
            Address = Console.ReadLine();

            Console.WriteLine("Enter a description:");
            Description = Console.ReadLine();

            Console.WriteLine("Enter an contact phone:");
            ContactPhone = Console.ReadLine();

            Console.WriteLine("Enter an email:");
            Email = Console.ReadLine();
        }

        public void Input(string address, string name, string description, string contactPhone,string email)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.ContactPhone= contactPhone;
            this.Email = email;
        }

        public void Print()
        {
            Console.WriteLine($"\nShop info:\n" +
                $"Name: {Name}\n" +
                $"Address: {Address}\n" +
                $"Description: {Description}\n" +
                $"Contact Phone: {ContactPhone}\n" +
                $"Email: {Email}");
        }
    }
}

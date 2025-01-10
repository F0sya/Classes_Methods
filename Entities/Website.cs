using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class Website
    {
        private string Url { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string Ip { get; set; }

        public Website()
        {
            Url = "NaN";
            Name = "NaN";
            Description = "NaN";
            Ip = "0.0.0.0";
        }
        public Website(string url, string name, string description, string ip)
        {
            Url = url;
            Name = name;
            Description = description;
            Ip = ip;
        }

        public void Input()
        {
            Console.WriteLine("Enter a name of website: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter an url: ");
            Url = Console.ReadLine();

            Console.WriteLine("Enter a description:");
            Description = Console.ReadLine();

            Console.WriteLine("Enter an ip address of website:");
            Ip = Console.ReadLine();
        }

        public void Input(string url, string name, string description, string ip)
        {
            this.Name = name;
            this.Url = url;
            this.Description = description;
            this.Ip= ip;
        }

        public void Print()
        {
            Console.WriteLine($"\nWebsite info:\n" +
                $"Name: {Name}\n" +
                $"Url: {Url}\n" +
                $"Description: {Description}\n" +
                $"Ip: {Ip}");
        }
    }
}

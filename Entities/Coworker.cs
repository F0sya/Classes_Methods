using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Methods.Entities
{
    internal class Coworker
    {
        private string Name { get; set; }
        private string BirthdayDate { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }
        private string Position { get; set; }
        private string[] JobChoirs { get; set; }
    
        
        public Coworker() { }

        public void Input()
        {
            Console.WriteLine("Enter full name of coworker: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter birthday date of coworker: ");
            BirthdayDate = Console.ReadLine();

            Console.WriteLine("Enter email of coworker: ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter position of coworker: ");
            Position = Console.ReadLine();

            Console.WriteLine("Enter job choirs of coworker(divided by spaces): ");
            JobChoirs = Console.ReadLine().Split();
        }

        public void Print()
        {
            Console.WriteLine($"\nFull name: {Name}");
            Console.WriteLine($"Birthday date: {BirthdayDate}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine("Choirs: ");
            foreach(string choir in JobChoirs)
            {
                Console.Write(choir + " ");
            }
        }
    
    }


}

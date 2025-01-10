using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Classes_Methods.Entities;

namespace Classes_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Solovyova St", "Journal name", "Default shop", "+3801234567", "johnapple@gmail.com");
            shop.Print();
        }
    }
}

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
            Journal journal = new Journal("2007", "Journal name", "Default journal", "+3801234567", "johnapple@gmail.com");
            journal.Print();
        }
    }
}

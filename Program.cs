using Classes_Methods.Entities;
using System.ComponentModel;

namespace Classes_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane("Antonov An-225 Mriya", "Antonov Serial Production Plant", 1985, "Transport");
            plane.Print();
        }
    }
}

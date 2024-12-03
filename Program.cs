using Classes_Methods.Entities;
using System.ComponentModel;

namespace Classes_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coworker coworker = new Coworker();

            coworker.Input();
            coworker.Print();
        }
    }
}

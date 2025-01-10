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
            Website website = new Website("mystat.itstep.org", "Mystat ITSTEP", "ITSTEP diary", "255.255.255.255");
            website.Print();
        }
    }
}

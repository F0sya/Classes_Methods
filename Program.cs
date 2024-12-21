using System.ComponentModel;
using System.Data;

namespace Classes_Methods
{
    internal class Program
    {
        static void Sqr(char x)
        {
            for (int i = 0; i < 10; i++){
                Console.Write(x + " ");
            }
            Console.Write('\n');
            for(int i = 0; i < 8; i++)
            {
                Console.Write(x);
                for(int k = 0; k < 17; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(x);
                Console.Write('\n');
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(x + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an char:");
            char symbol = Convert.ToChar(Console.ReadLine());
            Sqr(symbol);
        }
    }
}

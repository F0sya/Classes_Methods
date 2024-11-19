using System.ComponentModel;

namespace Classes_Methods
{
    internal class Program
    {
        static bool IsSquare(int x)
        {
            int num = (int)Math.Sqrt(x);
            return num * num == x;
        }
        static bool IsFibo(int num)
        {
            if(num < 0) return false;

            return (IsSquare(5 * num * num + 4) || IsSquare(5 * num * num - 4)) ? true : false;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter a number:"); 
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((IsFibo(x) == true) ? "This number is a fibonacci" : "This number isn't a fibonacci");



        }

    }
}

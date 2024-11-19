using System.ComponentModel;

namespace Classes_Methods
{
    internal class Program
    {

        static int RangeMultiply(int l, int r)
        {
            int res = 1;

            for(int i = l; i <= r; i++)
            {
                res *= i;
            }

            return res;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter left limit:"); 
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter right limit:"); 
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Result of operation: {RangeMultiply(x,y)}");

        }

    }
}

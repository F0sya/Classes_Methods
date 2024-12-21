using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Classes_Methods
{
    internal class Program
    {
        static int[] Filtering(int[] original, int[] filter)
        {
            List<int> result = new List<int>();

            for(int i =0; i < original.Length; i++)
            {
                if (!Array.Exists(filter,element => element == original[i]))
                {
                    result.Add(original[i]);
                }
            }

            return result.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size of a list:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter an {i + 1} number:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] filter_arr = [1,2,3,4,5];

            int[] res = Filtering(arr, filter_arr);

            Console.WriteLine("Result:");
            for(int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} ");
            }
        }
    }
}

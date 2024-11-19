using System.ComponentModel;

namespace Classes_Methods
{
    internal class Program
    {
        static void Bubble(int[] arr, int choice)
        {
            for(int n = arr.Length; n > 0; n--)
            {
                for (int i = 1; i < n; i++)
                {
                    if(choice == 1)
                    {
                        if (arr[i - 1] > arr[i])
                        {
                            (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                        }
                    }
                    else if (choice == 2)
                    {
                        if (arr[i - 1] < arr[i])
                        {
                            (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        Environment.Exit(0);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = [5,8,9,1,3,4];
            int choice;
            Console.Write("Before sorting: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n(1) Ascending order\n(2) Descending order");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("After sorting: ");
            Bubble(arr, choice);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }






        }

    }
}

using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Classes_Methods
{
    internal class Program
    {
        static bool isPalindrome(int x)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(Convert.ToString(x));


            bool check = false;
            for(int i =0; i < sb.Length / 2; i++)
            {
                check = (sb[i] == sb[sb.Length - 1 - i]) ? true : false;
            }
            return check;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an num:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (isPalindrome(num)) { Console.WriteLine("It's palindrome"); }
            else { Console.WriteLine("It's not palindrome"); }
        }
    }
}

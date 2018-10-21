using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome
{
    class Program
    {
  static bool PolindromeString(string text)
        {
            if (text.Length == 1)
                return true;
            else
            {
                for (int i = 0; i <= text.Length / 2; i++)
                {
                    if (text[i] == text[text.Length - i - 1])
                        continue;               
                else
                        return false;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            string text = Convert.ToString(Console.ReadLine());
            if (PolindromeString(text)==true)
                Console.WriteLine("polindrome");
            else
                Console.WriteLine("NOT polindrome");
            Console.ReadKey();
        }                    
    }
}


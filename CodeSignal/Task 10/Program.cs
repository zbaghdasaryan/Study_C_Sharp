//Given two strings, find the number of common characters between them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            commonCharacterCount("aabcc", "adcaa");
            Console.ReadKey();
        }
        static void commonCharacterCount(string s1, string s2)
        {
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        s2 = s2.Remove(j, 1);
                        count++;
                        break;
                    }
                }             
            }
            Console.WriteLine(count);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_String
{
    static class Convert<T> where T : struct
    {
        public static T? Get(string text)
        {
            T? ret = null;
            try
            {
                ret = (T)Convert.ChangeType(text, typeof(T));
            }
            catch (FormatException e)
            {
                Console.WriteLine("wrong type");
                Console.WriteLine(e.Message);
            }
            return ret;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the text ");
            string text = Console.ReadLine();
            char? newType = Convert<char>.Get(text);
            Console.WriteLine(newType);
            Console.ReadLine();
        }
    }
}
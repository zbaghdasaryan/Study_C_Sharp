using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                rr y = new rr(5);
            }
            catch(Exception t)
            {
                Console.WriteLine(  t.Message);
            }

            try
            {
                int a = int.Parse(Console.ReadLine());
                try { Console.WriteLine(100 / a); }
                catch (DivideByZeroException zero)
                {
                    Console.WriteLine(zero.Message);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }

    class rr
    {
        int yy;
        public rr(int a)
        {
            if (a == 5)
                throw new Exception("5 chilni");

            yy = a;
        }
    }
}

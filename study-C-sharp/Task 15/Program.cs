using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                int a;
                int b;
                int c;
                bool flag = true;
                for (int i=100; i<1000; i++)
                {
                    a = i / 100;
                    b = (i - a * 100) / 10;
                    c = i %10;
                    if (i==7*b*c)
                    {
                        flag = false;
                        Console.WriteLine(i);
                    }
                     
                }
                if (flag)
                Console.WriteLine("tenc tiv chka");
            }
                Console.ReadKey();
 
        }
    }
}

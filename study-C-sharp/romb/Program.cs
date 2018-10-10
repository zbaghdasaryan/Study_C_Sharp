using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romb
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
       
            
            for (int i = 0; i <= l; i++)
            {
                Console.SetCursorPosition(l-i, i);
                Console.WriteLine('*');

                Console.SetCursorPosition(l + i, i);
                Console.WriteLine('*');

                Console.SetCursorPosition(l - i, 2*l - i);
                Console.WriteLine('*');

                Console.SetCursorPosition(l + i, 2*l - i);
                Console.WriteLine('*');
            }
            Console.ReadKey();
    } 
    }
}

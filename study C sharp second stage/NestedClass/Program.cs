using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass mC = new MainClass();
            mC.Nam = new MainClass.NestedClass();
            mC.Nam.MethodNC();
            mC.MainClassMethod();
            
            MainClass.NestedClass nC = new MainClass.NestedClass();
            nC.MethodNC();
            Console.ReadKey();

            MainClass.DerivedNested dN = new MainClass.DerivedNested("Hello");

            Console.WriteLine(dN.GetFiled());

            dN.BaseMethod();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class MainClass
    {
        public string Name { get; set; }
        public void MainClassMethod()
        {
            Console.WriteLine("method form class Main Class");
        }
        public class NestedClass
        {
            public void MethodNC()
            {
                Console.WriteLine("method from Nested Class");
            }
        }
        public class DerivedNested : BaseClass
        {
            private string filed;
            public DerivedNested(string s)
            {
                filed = s;
            }
            public string GetFiled()
            {
                return filed;
            }

            
           
        }
    }
}

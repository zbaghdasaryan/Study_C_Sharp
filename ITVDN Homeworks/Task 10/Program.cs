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
            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelantPupil();
            ClassRoom group = new ClassRoom(p1,p2);

            group.Study();
            Console.WriteLine(new string('-', 30));
            group.Read();
            Console.WriteLine(new string('-', 30));
            group.Relax();
            Console.WriteLine(new string('-', 30));
            group.Write();
            Console.WriteLine(new string('-', 30));
            Console.ReadKey();
        }
    }
}

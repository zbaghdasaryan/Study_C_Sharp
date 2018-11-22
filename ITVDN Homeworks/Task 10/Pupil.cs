using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("method Pupil Study()");
        }
        public virtual void Read()
        {
            Console.WriteLine("method Pupil Read()");
        }
        public virtual void Write()
        {
            Console.WriteLine("method Pupil Write()");
        }
        public virtual void Relax()
        {
            Console.WriteLine("merhod Pupil Relax()");
        }
    }
    class ExcelantPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent Puple Study");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent Puple Read");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent Puple Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent Puple Relax");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good Puple Study");
        }
        public override void Read()
        {
            Console.WriteLine("Good Puple Read");
        }
        public override void Write()
        {
            Console.WriteLine("Good Puple Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Good Puple Relax");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad Puple Study");
        }
        public override void Read()
        {
            Console.WriteLine("Bad Puple Read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad Puple Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad Puple Relax");
        }
    }
}

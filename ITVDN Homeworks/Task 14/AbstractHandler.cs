using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    abstract class AbstractHandler
    {
        protected string fileName;
        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }
        public void Open()
        {
            Console.WriteLine(fileName + " opened");
        }
        public void Creat()
        {
            Console.WriteLine(fileName + " created");
        }
        public void Chenge()
        {
            Console.WriteLine(fileName + " changed");
        }
        public abstract void Save();
    }
        class XMLHandler : AbstractHandler
        {
            public XMLHandler(string fileName) : base(fileName)
            {
            }

            public override void Save()
            {
                Console.WriteLine(fileName + " saved by format XML"); ;
            }
        }
        class TXTHandler : AbstractHandler
        {
            public TXTHandler(string fileName) : base(fileName)
            {
            }

            public override void Save()
            {
                Console.WriteLine(fileName + "saved by format XML"); ;
            }
        }
        class DOCHandler : AbstractHandler
        {
            public DOCHandler(string fileName) : base(fileName)
            {
            }

            public override void Save()
            {
                Console.WriteLine(fileName + "saved by format DOC"); ;
            }
        }
    
}

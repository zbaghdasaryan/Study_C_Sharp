using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class ProDocumentWork:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("edit doc ");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("doc save in old version, for a new version use version Expert");
        }
    }
}

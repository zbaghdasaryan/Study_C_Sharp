using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class ExpertDocumentWorker : ProDocumentWork
    {
        public override void SaveDocument()
        {
            Console.WriteLine("doc save in a new version");
        }
    }
}

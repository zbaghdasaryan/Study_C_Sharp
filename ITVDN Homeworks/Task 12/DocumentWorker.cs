using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("doc opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("you can edit doc in version PRO");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("you can save doc in version PRO");
        }
    }
}

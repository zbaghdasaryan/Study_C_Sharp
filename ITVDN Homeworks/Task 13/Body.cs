using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Body : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else return "there is no body";
            }
            set { content = value; }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Title : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else return "there is no title";
            }
            set { content = value; }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
        }
    }
}

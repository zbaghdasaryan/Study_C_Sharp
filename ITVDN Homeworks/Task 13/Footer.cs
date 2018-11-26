using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Footer : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else return "there is no footer";
            }

            set { content = value; }

        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Body : Part
    {
        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "no document body";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}

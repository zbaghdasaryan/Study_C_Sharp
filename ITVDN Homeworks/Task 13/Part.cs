using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    abstract class Part
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}

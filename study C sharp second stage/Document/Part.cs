using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    abstract class Part
    {
        protected string content; //содержание
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}

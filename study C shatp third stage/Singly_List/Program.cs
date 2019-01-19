// Создание примитивного односвязного списка. 

// Создание трех узлов first, middle, last и связывание их между собой. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_List
{

    public class Node
    {
        public int Value
        {
            get;
            set;
        }

        public Node Next
        {
            get;
            set;
        }
    }

    class Program
    {

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        static void Main(string[] args)
        {

            // +-----+------+ 
            // |  3  | null + 
            // +-----+------+

            Node first = new Node()
            {
                Value = 3           // инициализация первого (first) узла списка значением 3
            };

            // +-----+------+    +-----+------+ 
            // |  3  | null +    |  5  | null + 
            // +-----+------+    +-----+------+ 

            Node middle = new Node()
            {
                Value = 5         // инициализация второго (middle) узла списка значением 5
            };

            // Создание связи между первым и вторым узлом списка

            // +-----+------+    +-----+------+ 
            // |  3  |  *---+--->|  5  | null +
            // +-----+------+    +-----+------+ 

            first.Next = middle;

            // +-----+------+    +-----+------+   +-----+------+ 
            // |  3  |  *---+--->|  5  | null +   |  7  | null + 
            // +-----+------+    +-----+------+   +-----+------+ 

            Node last = new Node()
            {
                Value = 7
            };

            // создание связи между вторым и третьим узлом списка

            // +-----+------+    +-----+------+   +-----+------+ 
            // |  3  |  *---+--->|  5  |  *---+-->|  7  | null + 
            // +-----+------+    +-----+------+   +-----+------+ 

            middle.Next = last;

            PrintList(first);

            Console.ReadKey();
        }
    }
}

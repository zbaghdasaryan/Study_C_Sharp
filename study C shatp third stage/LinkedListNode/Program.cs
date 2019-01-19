// Создание примитивного односвязного списка с помощью универсальных шаблонов (generic) 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode
{

    public class LinkedListNode<T>
    {

        // Создание нового узла со специальным значением.     

        public LinkedListNode(T value) // конструктор
        {

            Value = value;

        }

        // Значение узла.     

        public T Value // свойство  
        {
            get;
            set;
        }

        // Установка следующего значения для узла (null если последний).     

        public LinkedListNode<T> Next
        {
            get;
            set;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            LinkedListNode<string> first = new LinkedListNode<string>("Hello");
            LinkedListNode<string> second = new LinkedListNode<string>("world");

            // +-------+------+    +-------+-------+ 
            // | Hello |      +    | world | null  +
            // +-------+------+    +-------+-------+ 

            first.Next = second;

            // +-------+------+    +-------+-------+ 
            // | Hello |  *---+--->| world | null  +
            // +-------+------+    +-------+-------+ 

            Console.WriteLine(first.Value);
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(second.Value);

        }
    }
}

// Односвязные списки с которыми мы до этого работали, имели только один указатель из текущего узла на следующий.
// Двухсвязный список создается на основе односвязного и для этого нам понадобится добавить новое свойство Previous, для
// нахождения предыдущего элемента.

// +----------+---------+       +----------+----------+ 
// |          |     *---|------>|          |          |
// |     10   |         |       |          |    20    |
// |          |         |<------|---*      |          |
// +----------+---------+       +----------+----------+ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class LinkedList<T> : System.Collections.Generic.IEnumerable<T>
    {

        public LinkedListNode<T> _head;
        public LinkedListNode<T> _tail;

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public int Count
        {
            get;
            private set;
        }

        // Методы общие для односвязного и двухсвязного списка 

        #region Метод Contains возвращает значение true, если элемент пренадлежит списку

        public bool Contains(T item)
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        #endregion

        #region Метод получает нумератор для колекции

        // Возвращает экземпляр интерфейса IEnumerator <T>, который позволяет пронумеровать элементы связанного списка, 
        // от первого до последнего.

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();

        }


        #endregion

        #region Метод Clear очищает список

        public void Clear()
        {
            // Метод Clear очищет список, устанавливая _head и _tail в null. Достаточно удалить ссылки на элементы и сборщик мусора,
            // самостоятельно сотрет список.

            _head = null;
            _tail = null;
            Count = 0;
        }


        #endregion

        #region Метод CopyTo копирует содержимое списка в массив

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = _head;

            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        #endregion

        // Методы двухсвязного списка

        #region AddAfter



        #endregion

        #region Метод AddFirst добавляет новый элемент в начало списка


        // В то время как в односвязный список добавлять элементы можно только в конец, двухсвязный список позволяет добавлять
        // их и в начало. Для этого существует метод AddFirst.  

        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            // Сохранение узла head 
            LinkedListNode<T> temp = _head;

            // Указание нового значения начала списка 
            _head = node;

            // Установка указателя.     

            _head.Next = temp;

            if (Count == 0)
            {
                // Если список был пуст, то оба указателя указывают на новый узел.   

                _tail = _head;
            }
            else
            {
                // Реализация указателя на предыдущий узел
                // ДО:     head -------> 5 <-> 7 -> null
                // После:  head -> 3 <-> 5 <-> 7 -> null 

                temp.Previous = _head;
            }
            Count++;
        }
        #endregion

        #region Метод AddLast добавляет новый элемент в конец списка

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;

                // До:    Head -> 3 <-> 5 -> null         
                // После: Head -> 3 <-> 5 <-> 7 -> null         
                // 7.Previous = 5   

                node.Previous = _tail;
            }
            _tail = node;
            Count++;
        }

        #endregion

        #region Метод Remove удаляет из списка указанный элемент.

        //Метод возвращает true, если элемент найден и удален.  

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;

            // 1: Список пуст.     
            // 2: В списке один узел.     
            // 3: Если в списке много узлов:     
            //    a: Узел может быть первым.     
            //    b: Узел может быть последним или средним.  

            while (current != null)
            {
                // Head -> 3 -> 5 -> 7 -> null         
                // Head -> 3 ------> 7 -> null         
                if (current.Value.Equals(item))
                {
                    // Узел находится в середине или в конце списка              

                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        // Если это последний элемент списка - обновить _tail 

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                        else
                        {
                            // ДО: Head -> 3 <-> 5 <-> 7 -> null                     
                            // ПОСЛЕ:  Head -> 3 <-------> 7 -> null  

                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;

                }
                previous = current;
                current = current.Next;
            }
            return false;

        }
        #endregion

        #region Метод RemoveFirst удаляет первый элемент из списка

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // ДО:     Head -> 3 <-> 5         
                // Посли:  Head -------> 5  

                _head = _head.Next;
                Count--;

                if (Count == 0)
                {
                    _tail = null;
                }
                else
                {
                    _head.Previous = null;
                }
            }
        }


        #endregion

        #region Метод RemoveLast удалеят последний элемента из списка

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    // ДО: Head --> 3 <---> 7             
                    //         _tail = 7             
                    // ПОСЛЕ:  Head --> 3 --> null             
                    //         _tail = 3             

                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;

                }

                Count--;
            }
        }

        #endregion

    }

    class Program
    {

        public static void Display(LinkedList<int> words, string test)
        {
            Console.WriteLine();
            Console.WriteLine(test);
            foreach (int word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            LinkedList<int> instance = new LinkedList<int> { };

            instance.AddFirst(5);
            instance.AddFirst(3);
            instance.AddLast(7);

            Display(instance, "Doubly linked list");

            #region Удаление элемента из списка

            instance.Remove(5);

            Display(instance, "Doubly linked list");

            #endregion

            #region Определение пренадлежит ли элемент списку

            Console.WriteLine(instance.Contains(3));

            #endregion

            #region Копирование списка в массив

            Console.WriteLine("Копирование списка в массив");

            int[] arr = new int[5];

            instance.CopyTo(arr, 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            #region Удаление последнего элемента из списка

            instance.RemoveLast();

            Display(instance, "Doubly linked List");

            #endregion

            #region Удаление списка

            instance.Clear();

            Display(instance, "List is clear");

            #endregion



        }
    }
}

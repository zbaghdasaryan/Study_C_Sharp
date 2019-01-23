using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Method
{

    class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }
        public BinaryTreeNode<TNode> Left
        {
            get;
            set;
        }

        public BinaryTreeNode<TNode> Right
        {
            get;
            set;
        }

        public TNode Value
        {
            get;
            private set;
        }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

    }

    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;

        private int _count;

        #region Добавление нового узла дерева

        public void Add(T value)
        {
            // Первый случай: дерево пустое     

            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }

            // Второй случай: дерево не пустое, поэтому применяем рекурсивный алгорит 
            //                для поиска места добавления узла        

            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        // Рекурсивный алгоритм 

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Первый случай: значение добавляемого узла меньше чем значение текущего. 

            if (value.CompareTo(node.Value) < 0)
            {
                // если левый потомок отсутствует - добавляем его          

                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация               
                    AddTo(node.Left, value);
                }
            }
            // Второй случай: значение добавляемого узла равно или больше текущего значения      
            else
            {
                // Если правый потомок отсутствует - добавлем его.          

                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация

                    AddTo(node.Right, value);
                }
            }
        }

        #endregion

        #region Поиск узла в дереве

        // Метод Contains с помощью метода поиска FindWithParent определяется пренадлежит ли указанное значение дереву.

        public bool Contains(T value)
        {

            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        // Метод FindWithParent возвращает первый найденный узел.
        // Если значение не найжено, метод возвращает null.
        // Так же возвращает родительский узел для найденного значения.

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            // Поиск значения в дереве.     

            BinaryTreeNode<T> current = _head;
            parent = null;

            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    // Если искомое значение меньше значение текущего узла - переходим к левому потомку.             

                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // Если искомое значение больше значение текущего узла - переходим к правому потомку.

                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // Искомый элемент найден             
                    break;
                }
            }
            return current;
        }

        #endregion

        #region Нумератор 

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion 

        #region Количество узлов в дереве
        public int Count
        {
            get
            {
                return _count;
            }
        }
        #endregion

        #region Удаление узла дерева

        public bool Remove(T value)
        {
            BinaryTreeNode<T> current;
            BinaryTreeNode<T> parent;

            // Поиск узла для удаления

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }

            _count--;

            // Первый вариант: удаляемый узел не имеет правого потомка.     

            if (current.Right == null)
            {

                // Удаляем корень
                if (parent == null)
                {
                    _head = current.Left;
                }

                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        // Если значение узла родителя больше чем значение удаляемого узла -                 
                        // сделать левого потомка текущего узла - левым потомком родительского узла.                 

                        parent.Left = current.Left;
                    }

                    else if (result < 0)
                    {

                        // Если значение родительского узла меньше чем значение удаляемого узла -                  
                        // сделать левого потомка текущего узла - правым потомком родительского узла.                 

                        parent.Right = current.Left;

                    }
                }
            }

            // Второй вариант: удаляемый узел имеет правого потомка, у которого нет левого потомка.

            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                // Удаляем корень 
                if (parent == null)
                {
                    _head = current.Right;
                }

                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // Если значение родительского узла больше чем значение удаляемого узла -                  
                        // сделать правого потомка текущего узла - левым потомком родительского узла. 

                        parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        // Если значение родительского узла меньше чем значение удаляемого узла -                  
                        // сделать правого потомка текущего узла - правым потомком родительского узла. 

                        parent.Right = current.Right;

                    }
                }
            }
            // Третий вариант: удаляемый узел имеет правого потомка, у которого есть левый потомок.

            else
            {

                BinaryTreeNode<T> leftmost = current.Right.Left;
                BinaryTreeNode<T> leftmostParent = current.Right;

                // поиск крайнего левого потомка 
                while (leftmost.Left != null)

                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }

                // Правое поддерево крайнего левого узла, становится левым поддеревом его родительского узла.         
                leftmostParent.Left = leftmost.Right;

                // Присваиваем крайнему левому узлу в качестве левого потомка - левый потомок удаляемого узла,
                // а в качестве правого потомка - правый потомок удаляемого узла. 

                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                {
                    _head = leftmost;
                }

                else

                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0)
                    {

                        // Если значение родительского узла(parent), больше значения удаляемого узла (current) -                  
                        // сделать левого крайнего потомка удаляемого узла(leftmost)  - левым потомком его родителя(parent). 

                        parent.Left = leftmost;
                    }

                    else if (result < 0)

                    {

                        // Если значение родительского узла(parent), меньше значения удаляемого узла (current) -                  
                        // сделать левого крайнего потомка удаляемого узла(leftmost) - правым потомком его родителя(parent).

                        parent.Right = leftmost;
                    }
                }
            }

            return true;
        }

        #endregion

        #region Удаление дерева

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> instance = new BinaryTree<int>();

            instance.Add(8);    //                        8
            instance.Add(5);    //                      /   \
            instance.Add(12);   //                     5    12 
            instance.Add(3);    //                    / \   / \  
            instance.Add(7);    //                   3   7 10 15
            instance.Add(10);   //                         
            instance.Add(15);   //                        

            instance.Remove(8);

            instance.Clear(); // Раскомментировать 

            Console.WriteLine("Дерево содержит узел со значением 8: {0}", instance.Contains(8));
            Console.WriteLine("Дерево содержит узел со значением 5: {0}", instance.Contains(5));
            Console.WriteLine("Дерево содержит узел со значением 3: {0}", instance.Contains(3));
            Console.WriteLine("Дерево содержит узел со значением 7: {0}", instance.Contains(7));
            Console.WriteLine("Дерево содержит узел со значением 12: {0}", instance.Contains(12));
            Console.WriteLine("Дерево содержит узел со значением 10: {0}", instance.Contains(10));
            Console.WriteLine("Дерево содержит узел со значением 15: {0}", instance.Contains(15));

        }
    }
}

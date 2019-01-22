using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
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

        // Метод сравнивает значение двух узлов (Value и other), если Value меньше, то возвращается значение меньше нуля.
        //                                                       если они равны, то возвращается ноль,
        //                                                       если Value больше, то возвращается значение больше нуля.

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        public int CompareNode(BinaryTreeNode<TNode> other)
        {
            return Value.CompareTo(other.Value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {                                                            //               5
            BinaryTreeNode<int> Node1 = new BinaryTreeNode<int>(5);  //              / \
            BinaryTreeNode<int> Node2 = new BinaryTreeNode<int>(3);  //             /   \
            BinaryTreeNode<int> Node3 = new BinaryTreeNode<int>(8);  //            3     8


            if (Node1.CompareNode(Node2) >= 0)
            {
                Node1.Left = Node2;
            }

            else
            {
                Node1.Right = Node2;
            }


            if (Node1.CompareNode(Node3) >= 0)
            {
                Node1.Left = Node3;
            }

            else
            {
                Node1.Right = Node3;
            }

            Console.WriteLine("Левый потомок узла 5: {0}", Node1.Left.Value);
            Console.WriteLine("Правый потомок узла 5: {0}", Node1.Right.Value);

        }
    }
}



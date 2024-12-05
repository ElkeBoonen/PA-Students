using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADI_TREE
{
    internal class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            Root = null;
        }

        public BST(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Insert(Root, value);
            }
        }

        private void Insert(Node node, int value)
        {
            if (value < node.Key)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else 
                { 
                    Insert(node.Left, value);
                }
            }
            else if (value > node.Key)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        private void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Key + " ");
            InOrder(node.Right);
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            if (node == null) return;
            Console.Write(node.Key + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        private void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Key + " ");
        }

        internal bool Search(int value)
        {
            return Search(Root, value);
        }

        private bool Search(Node node, int value)
        {
            if (node == null) return false;
            if (node.Key == value) return true;

            if (value < node.Key) return Search(node.Left, value);
            else return Search(node.Right, value);
        }

        public int FindMin()
        {
            Node temp = Root;
            while (temp.Left != null)
            {
                temp = temp.Left;
            }
            return temp.Key;
        }

        public int FindMax()
        {
            Node temp = Root;
            while (temp.Right != null)
            {
                temp = temp.Right;
            }
            return temp.Key;
        }
    }
}

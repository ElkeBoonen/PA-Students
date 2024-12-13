using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    public class BST
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
                Add(Root, value);
            }
        }

        private void Add(Node node, int value)
        {
            if (node.Value > value)
            {
                if (node.Left == null) node.Left = new Node(value);
                else Add(node.Left, value);
            }
            else
            {
                if (node.Right == null) node.Right = new Node(value);
                else Add(node.Right, value);
            }
            
        }

        public void TraverseInOrder()
        {
            if (Root != null) TraverseInOrder(Root);
        }
        private void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left);
                Console.Write(node.Value + " ");
                TraverseInOrder(node.Right);
            }
        }

        public void TraversePreOrder()
        {
            if (Root != null) TraversePreOrder(Root);
        }
        private void TraversePreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                TraversePreOrder(node.Left);
                TraversePreOrder(node.Right);
            }
        }

        public void TraversePostOrder()
        {
            if (Root != null) TraversePostOrder(Root);
        }
        private void TraversePostOrder(Node node)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left);
                TraversePostOrder(node.Right);
                Console.Write(node.Value + " ");

            }
        }


        public bool Search(int value)
        {
            return Search(Root, value);
        }

        private bool Search(Node current, int value)
        {
            if (current == null) return false;
            if (current.Value == value) return true;

            else if (current.Value > value)
            {
                return Search(current.Left, value);
            }
            else
                return Search(current.Right, value);
        }

        internal int FindMin()
        {
            Node node = Root; 
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node.Value;
        }

        internal int FindMax()
        {
            Node node = Root;
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node.Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS_TREE
{
    internal class BT
    {
        public Node Root { get; set; }

        public BT(Node node)
        {
            Root = node;
        }

        public BT(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value) 
        {
            Add(Root, value);
        }

        private void Add(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                { 
                    Add(node.Left, value);
                }
            }
            else if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }

        }
        public bool Search(int value) 
        {
            return Search(Root, value);
        }

        private bool Search(Node node, int value)
        {
            if (node == null) return false;
            if (node.Value == value) return true; //leave this out, but change return true in the end!
            if (value < node.Value) return Search(node.Left, value);
            else if (value > node.Value) return Search(node.Right, value);
            return false;
        }

        public void InOrder() {
            InOrder(Root);
        }

        private void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }

        public void PreOrder() 
        {
            PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            if (node == null) return; ;
            Console.Write(node.Value + " ");
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
            Console.Write(node.Value + " ");
        }

        public int FindMin()
        {
            Node current = Root;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Value;
        }

        public int FindMax()
        {
            Node current = Root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }
    }
}

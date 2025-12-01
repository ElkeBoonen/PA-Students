using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PAStudents
{
    class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public int Value { get; set; }

        public TreeNode(int value)
        {
            this.Value = value;
            this.Left = null;
            Right = null;
        }

    }

    class BinaryTree
    {

        public TreeNode Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                TreeNode node = Root;
                while (true)
                {
                    if (value < node.Value)
                    {
                        if (node.Left == null)
                        {
                            node.Left = new TreeNode(value);
                            return;
                        }
                        node = node.Left;
                    }
                    else
                    {
                        if (node.Right == null)
                        {
                            node.Right = new TreeNode(value);
                            return;
                        }
                        node = node.Right;
                    }
                }
            }
        }

        public  void InOrder()
        {
            InOrder(Root);
        }
        private void InOrder(TreeNode node)
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
        private void PreOrder(TreeNode node)
        {
            if (node == null) return;
            
            Console.Write(node.Value + " ");
            InOrder(node.Left);
            InOrder(node.Right);
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }
        private void PostOrder(TreeNode node)
        {
            if (node == null) return;

            InOrder(node.Left);
            InOrder(node.Right);
            Console.Write(node.Value + " ");
        }
        
        public int Min()
        {
            TreeNode current = Root;
            while (true)
            {
                if (current.Left == null) return current.Value;
                current = current.Left;
            }
        }

        public int Max()
        {
            TreeNode current = Root;
            while (true)
            {
                if (current.Right == null) return current.Value;
                current = current.Right;
            }
        }

        public bool Search(int value)
        {
            TreeNode current = Root;
            while (current != null)
            {
                if (current.Value == value) return true;
                if (value < current.Value) current = current.Left;
                else current = current.Right;
            }
            return false;
        }

    }

}
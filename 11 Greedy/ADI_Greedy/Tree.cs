using System;
using System.Runtime.Intrinsics.Arm;

namespace ADI_Gredy
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class Tree
    {
        public Node Root { get; set; }

        public Tree(int value)
        {
             Root =new Node(value);
        }

        public int Greedy(Node node, int sum=0)
        {
            Console.WriteLine("call greedy");
            sum += node.Value;

            if (node.Left == null && node.Right == null) return sum;
            if (node.Right == null && node.Left != null) return Greedy(node.Left, sum);
            if (node.Right != null && node.Left == null) return Greedy(node.Right, sum);
            if (node.Left.Value > node.Right.Value) return Greedy(node.Left, sum);
            return Greedy(node.Right, sum);
        }

        public int Greedy()
        {
            int sum = 0;
            Node node = Root;

            while (node != null)
            {
                sum += node.Value;
                if (node.Left == null && node.Right == null) return sum;
                else if (node.Right == null && node.Left != null) node = node.Left;
                else if (node.Right != null && node.Left == null) node = node.Right;
                else if (node.Left.Value > node.Right.Value) node = node.Left;
                else node = node.Right;
            }
            return sum;
        }


        public int Other(Node node)
        {
            Console.WriteLine("call other");

            if (node == null) return 0;

            int left = Other(node.Left);
            int right = Other(node.Right);

            return node.Value + Math.Max(left, right);
        }


    }
}

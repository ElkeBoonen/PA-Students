using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSPS_Greedy
{
    class Node 
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

    internal class Tree
    {
        public Node Root { get; set; }

        public Tree(int value)
        {
            Root = new Node(value);
        }

        public int Greedy()
        {
            int sum = 0;

            sum += Root.Value;

            Node node = Root;

            return Greedy(Root, sum);
        }

        private int Greedy(Node node, int sum)
        {
            if (node.Left == null && node.Right == null) return sum;

            if (node.Left == null && node.Right != null) return Greedy(node.Right, sum + node.Right.Value);
            if (node.Right == null && node.Left != null) return Greedy(node.Left, sum + node.Left.Value);

            if (node.Left.Value > node.Right.Value) return Greedy(node.Left, sum + node.Left.Value);
            return Greedy(node.Right, sum + node.Right.Value);

        }


        public int GreedyWhile()
        {
            int sum = 0;
            Node node = Root;

            while (node != null)
            {
                sum += node.Value;

                if (node.Left == null && node.Right == null) return sum;
                else if (node.Left == null && node.Right != null) node = node.Right;
                else if (node.Right == null && node.Left != null) node = node.Left;
                else if (node.Left.Value > node.Right.Value) node = node.Left;
                else node = node.Right;
            }

            return sum;
        }

        public int Sum()
        {
            return Sum(Root);
        }

        private int Sum(Node node)
        { 
            int maxsum = 0, sum = 0;

            while (node != null)
            {
                sum += node.Value;
                maxsum = Math.Max(Sum(node.Left), Sum(node.Right));
                if (sum + maxsum > maxsum)
                {
                    maxsum += sum;
                }
                return maxsum;
            }
            return maxsum;
        }


        public int OtherSum(Node node)
        {
            if (node == null) return 0;

            int left = OtherSum(node.Left);
            int right = OtherSum(node.Right);

            return node.Value + Math.Max(left, right);
        
        }

    }
}

using System;

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

        public int Greedy()
        { }

        public int Other()
        { }
    }
}

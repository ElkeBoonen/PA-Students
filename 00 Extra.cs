using System;


namespace PAStudents
{
    class Tree
    {
        public TreeNode Root { get; set; }
        private Queue<TreeNode> queue = new Queue<TreeNode>();

        public Tree(int[] nodes)
        {
            Root = null;
            foreach (int value in nodes)
            {
                this.Insert(value);
            }

        }

        private void Insert(int value)
        {
            Console.WriteLine("\n\nnieuwe waarde --> " + value);
            if (Root == null)
            {
                Root = new TreeNode(value);
                queue.Enqueue(Root);
                queue.Enqueue(Root);
            }
            else
            {
                Console.WriteLine("queue --> " + string.Join(" ", queue));
                TreeNode node = queue.Dequeue();
                Console.WriteLine("dequeue -->" + node.Value);

                if (node.Left == null)
                {
                    node.Left = new TreeNode(value);
                    queue.Enqueue(node.Left);
                }
                else if (node.Right == null)
                {
                    node.Right = new TreeNode(value);
                    queue.Enqueue(node.Right);
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

        public  void PreOrder()
        {
            PreOrder(Root);
        }
        private void PreOrder(TreeNode node)
        {
            if (node == null) return;
            Console.Write(node.Value + " ");

            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public int GreedySum()
        {
            TreeNode node = Root;
            int som = 0;
            while (node != null)
            {
                som += node.Value;
                if (node.Left.Value > node.Right.Value)
                {
                    node = node.Left;
                }
                else node = node.Right;
            }
            return 0;
        }

        public int Sum()
        {
            return 0;
        }
    }
}
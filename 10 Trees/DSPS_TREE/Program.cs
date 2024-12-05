namespace DSPS_TREE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BT tree = new BT(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(4);
            tree.Add(6);
            tree.Add(8);

            Console.WriteLine("IN ORDER");
            tree.InOrder();
            Console.WriteLine("\nPRE ORDER");
            tree.PreOrder();
            Console.WriteLine("\nPOST ORDER");
            tree.PostOrder();

            Console.WriteLine("\n\n5? " + tree.Search(5));
            Console.WriteLine("10? " + tree.Search(10));
            Console.WriteLine("6? " + tree.Search(6));

            Console.WriteLine("\nMinimum: " + tree.FindMin());
            Console.WriteLine("Maximum: " + tree.FindMax());

        }
    }
}

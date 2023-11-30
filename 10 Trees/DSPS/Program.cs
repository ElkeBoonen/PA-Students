namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BST tree = new BST();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(4);
            tree.Add(6);
            tree.Add(8);


            Console.WriteLine("In-order traversal:");
            tree.TraverseInOrder();

            Console.WriteLine("\nPre-order traversal:");
            tree.TraversePreOrder();

            Console.WriteLine("\nPost-order traversal:");
            tree.TraversePostOrder();

            Console.WriteLine("\nFound 4? " + tree.Search(4));
            Console.WriteLine("Found 10? " + tree.Search(10));

            Console.WriteLine("Min: " + tree.FindMin());
            Console.WriteLine("Max: " + tree.FindMax());


        }
    }
}
namespace DSPS_Greedy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] classes = { "art", "eng", "math", "cs", "music" };
            double[] start = { 9, 9.5, 10, 10.5, 11 };
            double[] end = { 10, 10.5, 11, 11.5, 12 };
            Scheduling act = new Scheduling(classes, start, end);
            List<string> schedule = act.Run();
            Console.WriteLine(String.Join(" ", schedule));


            classes = new string[] { "bio", "art", "eng", "math", "cs", "music" };
            start = new double[] { 8.5, 9, 9.5, 10, 10.5, 11 };
            end = new double[] { 9, 10, 10.5, 11, 11.5, 12 };
            act = new Scheduling(classes, start, end);
            schedule = act.Run();
            Console.WriteLine(String.Join(" ", schedule));

            Tree tree = new Tree(40);
            tree.Root.Left = new Node(25);
            tree.Root.Right = new Node(29);
            tree.Root.Left.Left = new Node(35);
            tree.Root.Left.Right = new Node(40);
            tree.Root.Right.Right = new Node(12);

            Console.WriteLine(tree.Greedy());
            Console.WriteLine(tree.GreedyWhile());
            Console.WriteLine(tree.Sum());
            Console.WriteLine(tree.OtherSum(tree.Root));



        }
    }
}

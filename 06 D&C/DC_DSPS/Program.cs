namespace DC_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();

            Console.WriteLine(sum.Iterative(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(sum.Recursive(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(sum.Recursive(new int[] { 1, 2, 3, 4 }, 0, 0));

            Console.WriteLine(sum.DC((new int[] { 1, 2, 3, 4 }).ToList<int>()));

            //main
            List<int> list = new List<int> { 12, 56, 34, 78, 23, 89, 45, 67, 90, 21 };

            Console.WriteLine(String.Join(" ", list));

            QuickSort qs = new QuickSort();
            list = qs.Sort(list);

            Console.WriteLine(String.Join(" ", list));

            list = new List<int> { 12, 56, 34, 12, 78, 23, 89, 23, 23, 45, 67, 90, 21 };
            Console.WriteLine(String.Join(" ", list));
            list = qs.Sort2(list);
            Console.WriteLine(String.Join(" ", list));

            Hanoi hanoi = new Hanoi();
            hanoi.Solve(10, 'A', 'B', 'C');

        }
    }
}
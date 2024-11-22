namespace IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SUM
            Sum sum = new Sum();
            int[] array = new int[] { 2, 7, -8, 3, 5, 10, 4, 8, -5, 1, -4, -10, 12, 27 };

            Console.WriteLine(sum.SolveIt(array));
            Console.WriteLine(sum.Solve(array));
            Console.WriteLine(sum.Solve(array.ToList()));

            //QUICKSORT
            List<int> list = new List<int>(array);
            QuickSort quickSort = new QuickSort();

            Console.WriteLine(String.Join(" ",list));
            list = quickSort.Solve(list);
            Console.WriteLine(String.Join(" ", list));

            //HANOI
            Hanoi hanoi = new Hanoi();
            hanoi.Solve(10, 'A', 'C', 'B');

        }
    }
}
namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            Console.WriteLine(sum.Iterative(new int[] { 1, 3, 7, 10, 6 }));
            Console.WriteLine(sum.DCList(new List<int>(new int[] { 1, 3, 7, 10, 6 })));
            Console.WriteLine(sum.DCList(new List<int>()));
            Console.WriteLine(sum.DCArray(new int[] { 1, 3, 7, 10, 6 }));
            

            List<int> list = new List<int>(new int[] { 2,7,9,1,10,8,14,21,4,5,18,19 });
            Console.WriteLine(String.Join(" ", list));

            Quicksort quicksort = new Quicksort();
            Console.WriteLine(String.Join(" ", quicksort.Sort(list)));

            int[] array = new int[] { 2, 7, 9, 1, 10, 8, 14, 21, 4, 5, 18, 19 };
            quicksort.Sort(array, 0, array.Length - 1);
            Console.WriteLine(String.Join(" ", array));


            Hanoi hanoi = new Hanoi();
            Console.WriteLine("1 DISK");
            hanoi.Solve(1, 'A', 'C', 'B');

            Console.WriteLine("2 DISK");
            hanoi.Solve(2, 'A', 'C', 'B');

            Console.WriteLine("7 DISK");
            hanoi.Solve(7, 'A', 'C', 'B');


        }
    }
}
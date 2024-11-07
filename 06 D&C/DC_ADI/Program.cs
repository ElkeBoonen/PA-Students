namespace DC_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 10, 5, 20, 7 };

            Sum sum = new Sum();
            Console.WriteLine(sum.Iterative(array));
            Console.WriteLine(sum.Recursive(array));
            Console.WriteLine(sum.Recursive(array,0,0));
            Console.WriteLine(sum.DC(array.ToList()));

            //main
            List<int> list = new List<int> { 12, 56, 34, 78, 23, 89, 45, 67, 90, 21 };
            Console.WriteLine(String.Join(" ", list));
            QuickSort qs = new QuickSort();
            list = qs.Sort(list);

            list = new List<int> { 12, 56, 7, 12, 12, 34, 78, 23, 89, 89, 21, 45, 67, 90, 21 };
            Console.WriteLine(String.Join(" ", list));
            list = qs.Sort2(list);
            Console.WriteLine(String.Join(" ", list));

            Console.WriteLine(String.Join(" ", array));
            qs.Wikipedia(array, 0, array.Length - 1);
            Console.WriteLine(String.Join(" ", array));


            Hanoi hanoi = new Hanoi();
            hanoi.Solve(3, 'A', 'C', 'B');


        }
    }
}

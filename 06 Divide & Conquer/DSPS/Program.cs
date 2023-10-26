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

        }
    }
}
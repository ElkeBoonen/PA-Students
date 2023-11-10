namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fibonacci fibonacci = new Fibonacci();
            int n = 10;

            Console.WriteLine(fibonacci.Recursion(n));
            Console.WriteLine(fibonacci.Memoization(n, new int[n+1]));
            Console.WriteLine(fibonacci.Tabulation(n));
            Console.WriteLine(fibonacci.Iterative(n));
            */

            int[] array = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            RodCutting rodCutting = new RodCutting(array);

            Console.WriteLine(rodCutting.Recursion(4));
            Console.WriteLine(rodCutting.Memoization(4, new int[5]));
            Console.WriteLine(rodCutting.Tabulation(4));
        }
    }
}
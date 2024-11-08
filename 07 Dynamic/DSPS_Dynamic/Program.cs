namespace DSPS_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            /*
            Fibonacci fib = new Fibonacci();
            Console.WriteLine(fib.Iterative(n));
            Console.WriteLine(fib.Recursion(n));
            Console.WriteLine(fib.Memoization(n, new int[n+1]));
            Console.WriteLine(fib.Tabulation(n));
            */
            RodCutting rod = new RodCutting(new int[] { 0,1,5, 8, 9, 10, 17, 17, 20, 24, 30});
            Console.WriteLine(rod.Solve(n));
            Console.WriteLine(rod.Memoization(n, new int[n+1]));
            Console.WriteLine(rod.Tabulation(n));
            Console.WriteLine(rod.Binary(4));


        }
    }
}

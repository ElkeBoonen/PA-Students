namespace DSPS_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;

            Fibonacci fib = new Fibonacci();
            //Console.WriteLine(fib.Recursion(5));
            Console.WriteLine(fib.Iterative(n));
            Console.WriteLine(fib.Recursion(n));
            Console.WriteLine(fib.Memoization(n, new int[n+1]));
            Console.WriteLine(fib.Tabulation(n));
            //Console.WriteLine(fib.Recursion(1));

        }
    }
}

namespace ADI_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fibonacci fib = new Fibonacci();
            int n = 10;
            Console.WriteLine(fib.Iterative(n));
            Console.WriteLine(fib.Recursion(n));
            Console.WriteLine(fib.Memoization(n, new int[n+1]));
            Console.WriteLine(fib.Tabulation(n));
            */

            int n = 4;
            RodCutting rod = new RodCutting();
            Console.WriteLine(rod.Recursion(n));
            Console.WriteLine(rod.Memoization(n, new int[n+1]));
            Console.WriteLine(rod.Tabulation(n));
            rod.Binary(n);
        }
    }
}

namespace IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;

            Fibonacci fib = new Fibonacci();
            Console.WriteLine("\n" + fib.Recursion(n));
            Console.WriteLine("\n" + fib.Memoization(n,new int[n+1]));
            Console.WriteLine("\n" + fib.Tabulation(n));
            Console.WriteLine("\n" + fib.Iterative(n));

            n = 4;
            RodCutting rod = new RodCutting(new int[] { 0,1, 5,8,9,10,17,17,20,24,30});
            Console.WriteLine("\n" + rod.Recursion(n));
            Console.WriteLine("\n" + rod.Memoization(n, new int[n+1]));
            Console.WriteLine("\n" + rod.Tabulation(n));


        }
    }
}
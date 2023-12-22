namespace DSPS___Trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                int[] input = Array.ConvertAll("3 1 9 2".Trim().Split(" "), Int32.Parse);
                Console.WriteLine(String.Join(" ", input));

                Greatest greatest = new Greatest(input);
                Console.WriteLine(greatest.BruteForce());
                Console.WriteLine(greatest.BruteForce(0, Int32.MinValue));

                Console.WriteLine(greatest.Other());
                Console.WriteLine(greatest.Linear());

                Console.WriteLine(greatest.Greedy());


            }
            catch {
                Console.WriteLine("Crazy input!");
            }

        }
    }
}
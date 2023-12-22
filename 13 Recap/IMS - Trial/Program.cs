namespace IMS___Trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Trim().Split(" ");

            try
            {
                string[] input = "3 1 9 2".Trim().Split(" ");
                int[] nrs = Array.ConvertAll(input, Int32.Parse);

                Solutions solutions = new Solutions(nrs);
                Console.WriteLine(solutions.BruteForce());
                
                Console.WriteLine(solutions.Linear());
                Console.WriteLine(solutions.Greedy());

            }
            catch {
                Console.WriteLine("Crazy input!");
            }

           
        }
    }
}
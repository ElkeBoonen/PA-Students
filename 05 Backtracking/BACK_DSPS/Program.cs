namespace BACK_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queens queens = new Queens(8);
            queens.Solve(0);
            Console.WriteLine(queens);


            List<int> input = new List<int> { 7, 10, 4 };
            Subset subset = new Subset();

            foreach (var item in subset.Solve(input))
            {
                Console.WriteLine(String.Join(" ", item));
            }

        }
    }
}

namespace IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            NQueens nQueens = new NQueens(10);
            nQueens.Solve(0);
            Console.WriteLine(nQueens);

            SubsetProblem subsetProblem = new SubsetProblem();
            List<List<int>> results = subsetProblem.Solve(new int[]{ 4, 8, 10});
            foreach (var item in results)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
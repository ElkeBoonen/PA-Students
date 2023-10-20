namespace IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            NQueens nQueens = new NQueens(10);
            nQueens.Solve(0);
            Console.WriteLine(nQueens);
        }
    }
}
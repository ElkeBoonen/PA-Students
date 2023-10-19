namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NQueens nqueens = new NQueens(6);
            Console.WriteLine(nqueens);
        }
    }
}
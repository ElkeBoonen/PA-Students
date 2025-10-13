using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {

            NQueens nQueens = new NQueens(4);
            Console.WriteLine(nQueens);
            nQueens.Solve(0);

            Subset subset = new Subset(new int[] { 1, 2, 3 });
            subset.Solve(new List<int>());
            
        }
    }
} 
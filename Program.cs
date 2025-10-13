using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {

            NQueens nQueens = new NQueens(8);
            Console.WriteLine(nQueens);

            nQueens.Solve(0);
        }
    }
} 
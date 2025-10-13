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
        }
    }
} 
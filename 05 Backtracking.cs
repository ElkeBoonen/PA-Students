using System;

namespace PAStudents
{
    class NQueens
    {
        private char[,] board;
        private int size;

        public NQueens(int s)
        {
            this.size = s;
            board = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        public bool Solve(int col)
        { }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    s += board[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
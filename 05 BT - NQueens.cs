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

        public bool IsSafe(int col, int row)
        {
            //row checken
            for (int i = 0; i < size; i++)
            {
                if (board[row, i] == 'Q') return false;
            }

            //col checken
            for (int i = 0; i < size; i++)
            {
                if (board[i, col] == 'Q') return false;
            }

            //diagonaal naar boven
            for (int i = col, j = row; i >= 0 && j >= 0; i--, j--)
            {
                if (board[j, i] == 'Q') return false;
            }

            for (int i = col, j = row; i >= 0 && j < size; i--, j++)
            {
                if (board[j, i] == 'Q') return false;
            }
            return true;
        }

        public bool Solve(int col=0)
        {
            if (col == size) return true; //BASE CASE

            for (int i = 0; i < size; i++)
            {
                if (IsSafe(col, i))
                {
                    board[i, col] = 'Q';
                    Console.WriteLine(this);
                    if (Solve(col + 1)) return true;
                    board[i, col] = '-';
                    Console.WriteLine(this);
                }                
            }
            return false;
        }

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
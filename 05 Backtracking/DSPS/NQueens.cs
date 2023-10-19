using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class NQueens
    {
        char[,] board;

        public NQueens(int size)
        {
            board = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = '_';
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    s += board[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}

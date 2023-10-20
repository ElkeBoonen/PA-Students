using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class NQueens
    {
        int[,] board;
        int n;

        public NQueens(int size)
        {
            board = new int[size, size];
            n = size;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += board[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}

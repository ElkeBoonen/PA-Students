

namespace BACK_ADI
{
    internal class Queens
    {
        private bool[,] board;
        private int nrOfQueens;

        public Queens(int n)
        {
            nrOfQueens = n;
            board = new bool[nrOfQueens, nrOfQueens];

        }

        internal bool Solve(int column)
        {
            //Console.WriteLine(this);

            if (column == nrOfQueens)
            {
                return true;
            }

            for (int i = 0; i < nrOfQueens; i++)
            {
                if (IsSafe(i, column))
                {
                    board[i, column] = true;
                    if (Solve(column + 1)) return true;
                    board[i, column] = false;
                
                }
            }
            return false;

        }

        private bool IsSafe(int row, int col)
        {
            //bekijk col
            for (int i = row; i >= 0; i--)
            {
                if (board[i, col]) return false;
            }

            //bekijk row
            for (int i = col; i >= 0; i--)
            { 
                if (board[row, i]) return false;
            }

            //bekijk upper diag
            for (int i = row, j = col; i >= 0 && j >= 0; i--,j--)
            {
                if (board[i, j]) return false;
            }

            //bekijk lower diag
            for (int i = row, j = col; i < nrOfQueens && j >= 0; i++, j--)
            {
                if (board[i, j]) return false;
            }

            return true;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nrOfQueens; i++)
            {
                for (int j = 0; j < nrOfQueens; j++)
                {
                    if (board[i, j]) s += "Q";
                    else s += "-";
                    s += " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
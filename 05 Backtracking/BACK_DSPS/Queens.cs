
namespace BACK_DSPS
{
    internal class Queens
    {
        char[,] board;
        int nrOfQueens;
        public Queens(int n)
        {
            nrOfQueens = n;
            board = new char[nrOfQueens, nrOfQueens];

            for (int i = 0; i < nrOfQueens; i++)
            {
                for (int j = 0; j < nrOfQueens; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        private bool IsSafe(int row, int col)
        {
            //check column
            for (int i = row; i >= 0 ; i--)
            {
                if (board[i, col] == 'Q') return false;
            }

            //check row
            for (int i = col; i >= 0; i--)
            {
                if (board[row, i] == 'Q') return false; 
            }

            //check upper diagonal
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 'Q') return false;
            }

            //check lower diagonal
            for (int i = row, j = col; i < nrOfQueens && j >= 0; i++, j--)
            {
                if (board[i, j] == 'Q') return false;
            }
            return true;
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
                    board[i, column] = 'Q';
                    if (Solve(column + 1)) return true;
                    board[i, column] = '-';
                }
            }
            return false;

        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nrOfQueens; i++)
            {
                for (int j = 0; j < nrOfQueens; j++)
                {
                    s +=  board[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
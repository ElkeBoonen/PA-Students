using System;

namespace PAStudents
{
    class Maze
    {
        int[,] matrix;
        public Maze(int nodes)
        {
            matrix = new int[nodes, nodes];
        }

        public void AddEdge(int start, int end)
        {
            matrix[start, end] = 1;
            matrix[end, start] = 1;
        }

        public string DFS(int startnode)
        {
            string path = "";
            return path;
        }

        public override string ToString()
        {
            string result = "***MATRIX OUTPUT\n";
            result = "\t";

            for (int i = 0; i < matrix.GetLength(0); i++) result += i + "\t";
            result += "\n";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += i + "\t";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0) result += matrix[i, j] + "\t";
                    else result += "\t";
                }
                result += "\n";
            }

            result += "\n***LIST OUTPUT\n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += i + " --> ";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0) result += j + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
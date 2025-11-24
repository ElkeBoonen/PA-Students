using System;
using System.Diagnostics.Tracing;
using System.Xml;

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


        /*
        Start with a node!
        Store the nodes you have already visited!
        As long as there are (connected) nodes to visit:
            check children of node
            child already visited? do nothing
            child not visited yet? visit! (recursive call or push to stack)
        Implement with stack or recursion*/

        public string DFS(int startnode)
        {
            string path = "path: ";
            List<int> visited = new List<int>();
            Stack<int> stack = new Stack<int>();

            //we zetten onze startnode op de stack
            stack.Push(startnode);

            //zolang er nodes zitten op de stack doen we voort!
            while (stack.Count() != 0)
            {
                int node = stack.Pop();
                path += node + " ";

                //if (node == 0) return path;

                visited.Add(node); //node wordt bezocht

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if ((matrix[node, i] != 0) && !visited.Contains(i) && !stack.Contains(i))
                    {
                        stack.Push(i);
                    }
                }
            }
            return path;
        }

        public string DFSRecursion(int node, bool[] visited, string path="")
        {
            if (node == 0) return path + " we zijn op 0!";

            path += node + " ";
            visited[node] = true;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if ((matrix[node, i] != 0) && !visited[i])
                {
                    return DFSRecursion(i, visited, path);
                }
            }
            return path;
        }

        public string BFS(int startnode)
        {
            string path = "";
            bool[] visited = new bool[matrix.GetLength(0)];
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(startnode);

            while (queue.Count() != 0)
            {
                int node = queue.Dequeue();
                if (node == 0) return path;

                visited[node] = true;
                path += node + " ";

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[node, i] != 0 && !visited[i])
                    {
                        queue.Enqueue(i);
                    }
                }
            }
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
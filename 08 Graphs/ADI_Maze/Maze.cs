

using System.Collections;

namespace ADI_Maze
{
    internal class Maze
    {
        List<int>[] maze;

        public Maze(int nodes)
        {
            maze = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                maze[i] = new List<int> ();
            }
        }

        internal void AddEdge(int node1, int node2)
        {
            maze[node1].Add(node2);
            maze[node2].Add(node1);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < maze.Length; i++)
            {
                s += i + " --> ";
                foreach (int n in maze[i])
                {
                    s += n + " ";
                }
                s += "\n";
            }
            return s;
        }

        internal void DFSRecursion(int node, List<int> visited, int end = 0)
        {            
            visited.Add(node);
            Console.WriteLine("visit --> " + node);

            if (node == end) return;

            foreach (int next in maze[node])
            {
                if (!visited.Contains(next))
                { 
                    DFSRecursion(next, visited, end);
                    break;
                }
            }
        }

        internal void DFSStack(int start, int end = 0)
        {
            bool[] visited = new bool[maze.Length];
            Stack<int> stack = new Stack<int>();

            stack.Push(start);

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                Console.WriteLine("visit --> " + node);
               
                if (node == end) return;

                foreach (int next in maze[node])
                {
                    if (!visited[next])
                    {
                        stack.Push(next);
                        visited[node] = true;
                    }
                }
            }
        }

        internal void BFS(int start, int end = 0)
        {
            bool[] visited = new bool[maze.Length];
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                Console.WriteLine("visit --> " + node);
               
                if (node == end) return;

                foreach (int next in maze[node])
                {
                    if (!visited[next])
                    {
                        queue.Enqueue(next);
                        visited[next] = true;
                    }
                }
            }
        }
    }
}
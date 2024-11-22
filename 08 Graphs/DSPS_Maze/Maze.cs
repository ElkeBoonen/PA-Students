

namespace DSPS_Maze
{
    internal class Maze
    {
        List<int>[] maze;
        public Maze(int nodes)
        {
            maze = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                maze[i] = new List<int>();
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

        internal void DFS(int start, int exit = 0)
        {
            List<int> visitednodes = new List<int> ();
            Stack<int> stack = new Stack<int> ();
            stack.Push(start);

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                visitednodes.Add(node);

                Console.WriteLine("visit --> " + node);

                if (node == exit) return;

                foreach (int child in maze[node])
                {
                    if (!visitednodes.Contains(child))
                    { 
                        stack.Push(child);
                    }
                }
            }
        }

        internal void BFS(int start, int exit = 0)
        {
            List<int> visitednodes = new List<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                visitednodes.Add(node);

                Console.WriteLine("visit --> " + node);

                if (node == exit) return;

                foreach (int child in maze[node])
                {
                    if (!visitednodes.Contains(child))
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }

        internal void DFSRecursion(int start, int exit = 0)
        {
            List<int> visitednodes = new List<int>();
            RecursiveCall(start, exit, visitednodes);
        }

        private void RecursiveCall(int node, int exit, List<int> visitednodes)
        {
            visitednodes.Add(node);
            Console.WriteLine("visit --> " + node);

            if (node == exit) return;

            foreach (int child in maze[node])
            {
                if (!visitednodes.Contains(child))
                {
                    RecursiveCall(child, exit, visitednodes);
                    break;
                }
            }
        }

    }
}
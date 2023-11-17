using System.ComponentModel;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DSPS
{
    class Maze
    {
        int nodes;
        List<int>[] graph;

        public Maze(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];   //create graph with nr of nodes
            for (int i = 0; i < nodes; i++) //init all lists
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
            //maze.AddEdge(0, 1);
            //to make it better, check if a node already is in the list, not going out of bounds
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nodes; i++)
            {
                s += i + " --> " + String.Join(" ", graph[i]) + "\n";
            }
            return s;
        }

        public List<int> DFS(int start, List<int> visited)
        {
            if (visited == null) visited = new List<int>();
            visited.Add(start);
            foreach (int node in graph[start])
            {
                if (!visited.Contains(node))
                {
                    DFS(node, visited);
                }
            }
            return visited;
        }

        public List<int> DFS(int start, List<int> visited, int stop)
        {
            if (visited == null) visited = new List<int>();
            visited.Add(start);
            if (start == stop) return visited;

            foreach (int node in graph[start])
            {
                if (!visited.Contains(node))
                {
                    List<int> nodes = DFS(node, visited, stop);
                    if (nodes.Contains(stop)) return nodes;

                }
            }
            return visited;
        }

        public string DFS(int start)
        {
            string path = "";

            Stack<int> stack = new Stack<int>();
            stack.Push(start);

            while (stack.Count != 0)
            {
                int node = stack.Pop();

                if (!path.Contains(" " + node + " "))  path += " " + node + " ";

                foreach (int next in graph[node])
                {
                    if (!path.Contains(" " + next + " "))
                    {
                        stack.Push(next);
                    }
                }
            }

            return path;
        }

        public string BFS(int start, int stop)
        { 
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            List<int> visited = new List<int>();
            visited.Add(start);

            while (queue.Count != 0)
            {
                int node = queue.Dequeue();

                foreach (int neighbour in graph[node])
                {
                    if (!visited.Contains(neighbour))
                    { 
                        queue.Enqueue(neighbour);
                        visited.Add(neighbour);
                        if (node == stop) return String.Join(" -> ", visited);

                    }
                }
            }
            return String.Join(" -> ", visited);
        }


    }
}
using System.Net;

namespace IMS
{
    internal class Maze
    {
        private int nodes;
        List<int>[] graph;
        public Maze(int nodes)
        {
            this.nodes = nodes;

            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
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

        public void Dijkstra(int startnode)
        { 
            List<int> visited = new List<int>();
            int[] distances = new int[nodes];
            int[] previous = new int[nodes];
            for (int i = 0; i < nodes; i++)
            {
                distances[i] = Int32.MaxValue;
                previous[i] = -1;
            }

            distances[startnode] = 0;

            while (true)
            {
                int node = GetNextNode(distances, visited);

                if (node == -1) break;
                if (node == 0) break;

                visited.Add(node);

                foreach (var neighbour in graph[node])
                {
                    int cost = distances[node] + Math.Abs(node - neighbour);
                    if (distances[neighbour] > cost)
                    {
                        distances[neighbour] = cost;
                        previous[neighbour] = node;
                    }
                }
            }

            for (int i = 0; i < nodes; i++)
            {
                Console.WriteLine($" om aan {i} te geraken ga je via {previous[i]}");
            }

            int end = 0;
            string path = " ";
            while (end != startnode)
            {
                path = end + " " + path; 
                end = previous[end];
            }
            path = end + " " + path;

            Console.WriteLine(path);
        }

        private int GetNextNode(int[] distances, List<int> visited)
        {
            int node = -1;
            int min = Int32.MaxValue;
            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] < min && !visited.Contains(i))
                {
                    node = i;
                    min = distances[i];
                }
            }
            return node;
        }
    }
}
using Microsoft.VisualBasic;

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

        public void Dijkstra(int start)
        {
            int[] distances = new int[nodes];
            for (int i = 0; i < nodes; i++)
            {
                distances[i] = Int32.MaxValue;
            }

            List<int> visited = new List<int>();

            distances[start] = 0;

            string path = "";

            while (true)
            {
                int next = GetNextNode(distances, visited);

                if (next == 0) break;

                if (next == -1) break;

                visited.Add(next);

                path += next + " ";

                // for each neighbor ​calculate the cost and update if lower
                foreach (int neighbour in graph[next])
                {
                    int cost = distances[next] + Math.Abs(neighbour - next);
                    if (distances[neighbour] > cost) distances[neighbour] = cost;
                }
            }

            Console.WriteLine(path);
        }

        private int GetNextNode(int[] distances, List<int> visited)
        {
            int next = -1;
            int min = Int32.MaxValue;

            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] < min && !visited.Contains(i))
                {
                    min = distances[i];
                    next = i;
                }
            }
            return next;
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
    }
}
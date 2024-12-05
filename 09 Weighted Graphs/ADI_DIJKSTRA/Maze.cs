
using System.Net;

namespace ADI_DIJKSTRA
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

        private int FindNextNode(int[] distances, List<int> visited)
        {
            int minimum = Int32.MaxValue;
            int node = -1;

            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] < minimum && !visited.Contains(i))
                { 
                    minimum = distances[i];
                    node = i;
                }
            }
            return node;
        }

        internal string Dijkstra(int startnode, int endnode)
        {
            List<int> visited = new List<int>();

            int[] distances = new int[maze.Length];
            int[] previous = new int[maze.Length];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = Int32.MaxValue;
                previous[i] = -1;
            }

            distances[startnode] = 0;

            while (true) 
            { 
                int node = FindNextNode(distances, visited);
                if (node == -1) break;

                visited.Add(node);

                foreach (int neighbour in maze[node])
                {
                    int cost = Math.Abs(neighbour - node);
                    int temp_distance = distances[node] + cost;

                    if (!visited.Contains(neighbour) && temp_distance < distances[neighbour])
                    {
                        distances[neighbour] = temp_distance;
                        previous[neighbour] = node;
                    }
                }
            }

            /*for (int i = 0; i < distances.Length; i++)
            { 
                Console.WriteLine(i + " --> " + distances[i] + " --> previous node " + previous[i]);
            }*/

            int target = endnode;
            List<int> path = new List<int>() { target };
            while (target != startnode)
            {
                target = previous[target];
                path.Add(target);
            }
            path.Reverse();
            return "path: " + String.Join(" ",path); // 12 17 18 19 14 9 ...
        }
    }
}
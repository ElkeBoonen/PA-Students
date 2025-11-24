using System;
using System.Diagnostics.Tracing;
using System.Xml;

namespace PAStudents
{
    class Maze2
    {
        List<int>[] adj_list;
        public Maze2(int nodes)
        {
            adj_list = new List<int>[nodes];
            for (int i = 0; i < nodes; i ++)
            {
                adj_list[i] = new List<int>();
            }
        }

        public void AddEdge(int start, int end)
        {
            adj_list[start].Add(end);
            adj_list[end].Add(start);
        }

        public int NextNode(int[] distances, bool[] visited)
        {
            int node = -1;
            int min_distance = Int32.MaxValue;
            for (int i = 0; i < distances.Length; i++)
            {
                if (min_distance > distances[i] && !visited[i])
                {
                    min_distance = distances[i];
                    node = i;
                }
            }
            return node;
        }

        public string Dijkstra(int start, int end)
        {
            int[] distances = new int[adj_list.Length];
            bool[] visited = new bool[adj_list.Length];
            int[] path = new int[adj_list.Length];

            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = Int32.MaxValue;
            }

            distances[start] = 0;

            while (true)
            {
                int node = NextNode(distances, visited);
                if (node == -1) break;
                if (node == end) break;
                visited[node] = true;
                foreach (int neighbor in adj_list[node])
                {
                    int cost = Math.Abs(neighbor-node) + distances[node];

                    if (cost < distances[neighbor])
                    {
                        distances[neighbor] = cost;
                        path[neighbor] = node;
                    }
                }
            }

            string result = "";
            result += "Kortste pad kost " + distances[end] + "\n";
            int n = end;
            while (n != start)
            {
                result += n + " ";
                n = path[n];
            }
           
            return result + start;

        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < adj_list.Length; i++)
            {
                result += i + " --> ";
                foreach (int node in adj_list[i])
                {
                    result += node + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
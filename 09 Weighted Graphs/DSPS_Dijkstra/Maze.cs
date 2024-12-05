using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS_Dijkstra
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
            int smallest = Int32.MaxValue;
            int node = -1;

            for (int i = 0; i < distances.Length; i++)
            {
                if (!visited.Contains(i) && distances[i] < smallest)
                { 
                    smallest = distances[i];
                    node = i;
                }
            }
            return node;
        }

        public string Dijkstra(int startnode, int endnode)
        {
            int[] distances = new int[maze.Length];
            int[] previous = new int[maze.Length];

            List<int> visited = new List<int> ();
            for (int i = 0; i < maze.Length; i++)
            {
                distances[i] = Int32.MaxValue;
                previous[i] = -1;
            }

            distances[startnode] = 0;

            while (true)
            { 
                int nextnode = FindNextNode(distances, visited);
                if (nextnode == -1) break;
                visited.Add(nextnode);

                //Console.WriteLine(nextnode);

                foreach (int child in maze[nextnode])
                {
                    int temp = Math.Abs(child - nextnode) + distances[nextnode];
                    if (!visited.Contains(child) && temp < distances[child])
                    {
                        distances[child] = temp;
                        previous[child] = nextnode;
                    }
                }
            
            }

            int node = endnode;
            string path = "";
            while (node != startnode)
            { 
                path += node.ToString() + " ";
                node = previous[node];
            }
            path += node;
            return String.Join("",path.Reverse()) ;
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIJKSTRA___IMS
{
    class Maze
    {
        private List<int>[] _maze;

        public Maze(int nodes)
        {
            _maze = new List<int>[nodes];
        }

        //addEdge(0,1)
        public void AddEdge(int nodeA, int nodeB)
        {
            if (_maze[nodeA] == null)
            {
                _maze[nodeA] = new List<int>();
            }
            _maze[nodeA].Add(nodeB);

            if (_maze[nodeB] == null)
            {
                _maze[nodeB] = new List<int>();
            }
            _maze[nodeB].Add(nodeA);
        }


        /*
            -We will have to use a distances-array and a visited-array (same length as nodes)
            -Start with start-node!
            -While true 😨 (relax, we can take a break!)
                -get next node (the shortest distance of a node that is not already visited)
                -if node is -1 break! so there is no next node!
                -for each neighbor
​                   calculate the cost and update if lower
​             -Print out distance array
         */

        private int NextNode(bool[] visited, int[] distances)
        {
            int min = Int32.MaxValue;
            int next = -1;
            for (int i = 0; i < distances.Length; i++)
            {
                if (!visited[i] && distances[i] < min)
                {
                    min = distances[i];
                    next = i;
                }
            }
            return next;
        }

        public string Dijkstra(int start, int end)
        {
            bool[] visited = new bool[_maze.Length];
            int[] distances = new int[_maze.Length];
            int[] prev = new int[_maze.Length];

            for (int i = 0; i < _maze.Length; i++)
            {
                distances[i] = Int32.MaxValue;
                prev[i] = -1;
            }

            distances[start] = 0;

            while (true)
            {
                //get next node (the shortest distance of a node that is not already visited
                int next = NextNode(visited, distances);
                //-if node is -1 break! so there is no next node!
                if (next == -1) break;

                visited[next] = true;
                //-for each neighbor, calculate the cost and update if lower
                foreach (var item in _maze[next])
                {
                    int cost = Math.Abs(next - item);
                    if (distances[item] > cost + distances[next])
                    {
                        distances[item] = cost + distances[next];
                        prev[item] = next;
                    }
                }
            }

            string path = "";
            int node = end;
            while (node != start)
            {
                path = prev[node] + " " + path;
                node = prev[node];
            }
            return $"Path from {start} to {end}: " + path + end;
        }


        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < _maze.Length; i++)
            {
                s += i + " --> ";
                if (_maze[i] != null)
                {
                    foreach (var item in _maze[i])
                    {
                        s += item + " ";
                    }
                }
                s += Environment.NewLine;
            }
            return s;
        }
    }
}

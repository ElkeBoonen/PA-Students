using System;
using System.Collections.Generic;
using System.Text;

namespace DIJKSTRA___DSPS
{
    class Maze
    {
        List<int>[] _maze;
        public Maze(int nodes)
        {
            _maze = new List<int>[nodes];
            for (int i = 0; i < _maze.Length; i++)
            {
                _maze[i] = new List<int>();
            }
        }

        public void AddEdge(int nodeA, int nodeB)
        {
            _maze[nodeA].Add(nodeB);
            _maze[nodeB].Add(nodeA);
        }

        //the shortest distance of a node that is not already visited
        private int NextNode(int[] distances, bool[] visited)
        {
            int min = Int32.MaxValue;
            int index = -1;
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] < min && !visited[i])
                {
                    min = distances[i];
                    index = i;
                }
            }
            return index;
        }

        public string Dijkstra(int start, int end)
        {
            //use a distances-array and a visited-array 
            bool[] visited = new bool[_maze.Length];
            int[] distances = new int[_maze.Length];
            int[] prev = new int[_maze.Length];
            //initialize everything on Int32.Max & false
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = Int32.MaxValue;
                visited[i] = false;
                prev[i] = -1;
            }

            //Start with start-node!
            distances[start] = 0;

            //While true 😨 (relax, we can take a break!)
            while (true)
            {
                //get next node 
                int node = NextNode(distances, visited);
                //if node is -1 break! so there is no next node!
                if (node == -1) break;
                //visit the node!
                visited[node] = true;
                //for each neighbor
                foreach (var item in _maze[node])
                {
                    //calculate the cost and update if lower
                    int cost = Math.Abs(node - item);
                    if (distances[item] > distances[node] + cost)
                    {
                        distances[item] = distances[node] + cost;
                        prev[item] = node;
                    }
                }
            }
            /*//​Print out distance array
            for (int i = 0; i < distances.Length; i++)
                Console.WriteLine($"cost to {i}: {distances[i]} --> prev {prev[i]}");*/

            string path = "";
            int n = end;
            while (n != -1)
            {
                path = n + " " + path;
                n = prev[n];
            }

            return $"from {start} to {end} --> " + path;
        }


        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < _maze.Length; i++)
            {
                s += $"node {i}: ";
                foreach (var node in _maze[i])
                {
                    s += node + " ";
                }
                s += Environment.NewLine;
            }
            return s;
        }
    }
}

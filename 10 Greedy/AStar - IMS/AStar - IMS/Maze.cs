using System;
using System.Collections.Generic;
using System.Text;

namespace AStar___IMS
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

        private int NextNode(bool[] visited, int[] priorities)
        {
            int min = Int32.MaxValue;
            int next = -1;
            for (int i = 0; i < priorities.Length; i++)
            {
                if (!visited[i] && priorities[i] < min)
                {
                    min = priorities[i];
                    next = i;
                }
            }
            return next;
        }

        public string AStar(int start, int end)
        {
            bool[] visited = new bool[_maze.Length];
            int[] distances = new int[_maze.Length];
            int[] prev = new int[_maze.Length];
            int[] priorities = new int[_maze.Length];

            for (int i = 0; i < _maze.Length; i++)
            {
                distances[i] = Int32.MaxValue;
                priorities[i] = Int32.MaxValue;
                visited[i] = false;
                prev[i] = -1;
            }

            distances[start] = 0;
            priorities[start] = distances[start] + Heuristic(start,end);


            while (true)
            {
                int next = NextNode(visited, priorities);
                if (next == -1) break;

                visited[next] = true;
                foreach (var item in _maze[next])
                {
                    int cost = Math.Abs(next - item);
                    if (distances[item] > cost + distances[next])
                    {
                        distances[item] = cost + distances[next];
                        priorities[item] = distances[item] + Heuristic(item, end);

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

        private int Heuristic(int current, int end)
        {
            int x2 = current % 5;
            int x1 = end % 5;
            int y2 = current / 5;
            int y1 = end / 5;
            //manhattan distance
            int h = Math.Abs(x2 - x1) + Math.Abs(y2 - y1);
            return h;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs___DSPS
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

        public void DFS(int start)
        {
            bool[] visited = new bool[_maze.Length];
            visited[start] = true;
            DFS_Recursion(start, visited);     
        }

        public bool DFS_Recursion(int node, bool[] visited)
        {
            Console.Write(node + " ");
            if (node == 0) return true;

            foreach (var item in _maze[node])
            {
                if (!visited[item])
                {
                    visited[node] = true;
                    return DFS_Recursion(item, visited);
                }
            }
            return false;
        }

        public string DFS_Stack(int start)
        {
            bool[] visited = new bool[_maze.Length];
            string path = "";

            Stack<int> stack = new Stack<int>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                visited[node] = true;
                path += node + " ";

                if (node == 0) break;

                foreach (var item in _maze[node])
                {
                    if (!visited[item])
                    {
                        stack.Push(item);
                    }
                }
            }
            return path;
        }

        public string BFS(int start)
        {
            bool[] visited = new bool[_maze.Length];
            Queue<int> queue = new Queue<int>();
            string path = "";

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                visited[node] = true;

                path += node + " ";

                if (node == 0) break;

                foreach (var item in _maze[node])
                {
                    if (!visited[item])
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            return path;

        }

    }
}

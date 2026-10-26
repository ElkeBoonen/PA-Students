using System;
using System.IO;
using System.Collections.Generic;

namespace Les6
{
    class Maze
    {
        private int[,] maze; 
        private int size;

        public Maze(int size)
        {
            this.size = size;
            maze = new int[size,size];
        }

        private int ToNode(int row, int col)
        {
            return row*size + col;
        }

        public void AddEdge(int[] nodes) //gerichte graaf!!!!!
        {
            foreach(int node in nodes)
            {
                int row = node / size;
                int col = node % size;
                maze[row, col] = 1;
            }
        }

        private List<int> CheckNeighbours(int node)
        {
            List<int> nodes = new List<int>();

            int row = node / size;
            int col = node % size;

            if (row > 0 && maze[row-1,col]==1) nodes.Add(ToNode(row-1,col)); // boven
            if (col < size-1 && maze[row,col+1]==1) nodes.Add(ToNode(row,col+1)); //rechts
            if (row < size-1 && maze[row+1,col]==1) nodes.Add(ToNode(row+1,col)); //onder
            if (col > 0 && maze[row,col-1]==1) nodes.Add(ToNode(row,col-1)); //links
            
            return nodes;
        }

        public string BFS(int start)
        {
            string path = "";

            Queue<int> queue = new Queue<int>(); // te bezoeken!!!
            queue.Enqueue(start);

            List<int> visited = new List<int>(); //reeds bezocht!!
            
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (current == 0) return path + " AANGEKOMEN in 0!!";

                
                if (!visited.Contains(current))
                {
                    foreach (int neighbour in CheckNeighbours(current))
                    {
                        queue.Enqueue(neighbour);
                    }
                    visited.Add(current);
                    path += current + " --> " ;

                }
            }
            return path;
        }


        public string DFS(int start)
        {
            string path = "";

            Stack<int> stack = new Stack<int>(); // te bezoeken!!!
            stack.Push(start);

            List<int> visited = new List<int>(); //reeds bezocht!!
            
            while (stack.Count > 0)
            {
                int current = stack.Pop();
                if (current == 0) return path + " AANGEKOMEN in 0!!";
                
                if (!visited.Contains(current))
                {
                    foreach (int neighbour in CheckNeighbours(current))
                    {
                        stack.Push(neighbour);
                    }
                    visited.Add(current);
                    path += current + " --> " ;

                }
            }
            return path;
        }

        public string DFSRecursief(int current, List<int> visited, string path="")
        {
            if (current == 0) return path + " AANGEKOMEN in 0!!";

            path += current + " --> " ;

                
            if (!visited.Contains(current))
            {
                visited.Add(current);

                foreach (int neighbour in CheckNeighbours(current))
                {
                    return DFSRecursief(neighbour, visited, path);
                }
            }
            return path;
        }

        public override string ToString()
        {
            string s = "";
            for (int i =0; i < size; i++)
            {
                for (int j =0; j < size; j++)
                {
                    s += maze[i,j] + " ";
                }
                s+="\n";
            }
            return s;
        }


    }
}
﻿namespace DSPS_Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(25);

            maze.AddEdge(0, 1);
            maze.AddEdge(1, 2);
            maze.AddEdge(2, 3);
            maze.AddEdge(3, 4);
            maze.AddEdge(4, 9);
            maze.AddEdge(9, 14);
            maze.AddEdge(18, 17);
            maze.AddEdge(18, 19);
            maze.AddEdge(19, 14);
            maze.AddEdge(19, 24);
            maze.AddEdge(24, 23);
            maze.AddEdge(18, 23);
            maze.AddEdge(22, 23);
            maze.AddEdge(17, 12);
            maze.AddEdge(17, 22);
            maze.AddEdge(21, 22);
            maze.AddEdge(21, 20);
            maze.AddEdge(20, 15);
            maze.AddEdge(15, 10);
            maze.AddEdge(10, 5);
            maze.AddEdge(5, 0);

            Console.WriteLine(maze.ToString());

            Console.WriteLine("DFS");
            maze.DFS(12);
            Console.WriteLine("BFS");
            maze.BFS(12);


            Console.WriteLine("DFS RECURSION") ;
            maze.DFSRecursion(12);

            Console.WriteLine("DFS - exit 14");
            maze.DFS(12,14);
            Console.WriteLine("BFS - exit 14");
            maze.BFS(12,14);
        }
    }
        
}

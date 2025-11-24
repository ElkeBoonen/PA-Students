using System;
using System.Security.Cryptography;
using System.Text;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            Maze2 maze = new Maze2(25);

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
            maze.AddEdge(21, 22);
            maze.AddEdge(21, 20);
            maze.AddEdge(20, 15);
            maze.AddEdge(15, 10);
            maze.AddEdge(10, 5);
            maze.AddEdge(5, 0);

            Console.WriteLine(maze.Dijkstra(12,0));
            Console.WriteLine(maze.ToString());

            ChickenMaze cm = new ChickenMaze(10);

            cm.AddEdge(1,3,2);
            cm.AddEdge(1,2,10);
            cm.AddEdge(1,5,25);
            cm.AddEdge(2,3,10);
            cm.AddEdge(2,4,10);
            cm.AddEdge(2,6,20);
            cm.AddEdge(3,4,50);
            cm.AddEdge(3,5,5);
            cm.AddEdge(4,5,0);
            cm.AddEdge(4,7,10);
            cm.AddEdge(5,8,15);
            cm.AddEdge(6,7,50);
            cm.AddEdge(6,9,25);
            cm.AddEdge(7,8,5);
            cm.AddEdge(7,9,5);
            cm.AddEdge(8,9,2);

            Console.WriteLine(cm.Dijkstra(1,9));
            Console.WriteLine(cm.ToString());


        }
    }
} 
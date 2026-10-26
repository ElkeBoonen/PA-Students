using System;
using System.IO;
using System.Collections.Generic;

namespace Les6
{
    class Program
    {
        static void Main(string[] args)
        {    
            /*Mango mango = new Mango();
            //you → alice, bob, claire; alice → peggy; bob → anuj, peggy; claire → thom, jonny. Let op: de graaf is gericht.
            mango.AddEdge("you", "alice");
            mango.AddEdge("you", "bob");
            mango.AddEdge("you", "claire");
            mango.AddEdge("alice", "peggy");
            mango.AddEdge("bob", "anuj");
            mango.AddEdge("bob", "peggy");
            mango.AddEdge("claire", "thom");
            mango.AddEdge("claire", "jonny");

            Console.WriteLine(mango);

            Console.WriteLine(mango.BFS("you"));
            Console.WriteLine(mango.DFS("you"));*/

            Maze maze = new Maze(5);
            maze.AddEdge(new int[]{0,1,2,3,4,5, 10,15,20,9,14,19,24,21,22,23,17,18,12});
            Console.WriteLine(maze);
            Console.WriteLine(maze.BFS(12));
            Console.WriteLine(maze.DFS(12));
            Console.WriteLine(maze.DFSRecursief(12, new List<int>()));


        }
    }
}
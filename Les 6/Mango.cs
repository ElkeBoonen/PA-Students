using System;
using System.IO;
using System.Collections.Generic;

namespace Les6
{
    class Mango
    {
        private Dictionary<string, List<string>> netwerk;

        public Mango()
        {
            netwerk = new Dictionary<string,List<string>>();
        }

        public void AddEdge(string from, string to) //gerichte graaf!!!!!
        {
            if (!netwerk.ContainsKey(from)) netwerk[from] = new List<string>();
            netwerk[from].Add(to);
            if (!netwerk.ContainsKey(to)) netwerk[to] = new List<string>();
        }

        public string BFS(string start)
        {
            string path = "";

            Queue<string> queue = new Queue<string>(); // te bezoeken!!!
            queue.Enqueue(start);

            List<string> visited = new List<string>(); //reeds bezocht!!
            
            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                
                if (!visited.Contains(current))
                {
                    foreach (string neighbour in netwerk[current])
                    {
                        queue.Enqueue(neighbour);
                    }
                    visited.Add(current);
                    path += current + " --> " ;

                }
            }
            return path;
        }


        public string DFS(string start)
        {
            string path = "";

            Stack<string> stack = new Stack<string>(); // te bezoeken!!!
            stack.Push(start);

            List<string> visited = new List<string>(); //reeds bezocht!!
            
            while (stack.Count > 0)
            {
                string current = stack.Pop();
                
                if (!visited.Contains(current))
                {
                    foreach (string neighbour in netwerk[current])
                    {
                        stack.Push(neighbour);
                    }
                    visited.Add(current);
                    path += current + " --> " ;

                }
            }
            return path;
        }

        public override string ToString()
        {
            string s = "";
            foreach (var pair in netwerk)
            {
                s += pair.Key + " --> " + String.Join(" ", netwerk[pair.Key]) + "\n";
            }
            return s;
        }


    }
}
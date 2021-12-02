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

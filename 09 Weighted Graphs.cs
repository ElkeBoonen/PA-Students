using System;
using System.Diagnostics.Tracing;
using System.Xml;

namespace PAStudents
{
    class Maze2
    {
        List<int>[] adj_list;
        public Maze2(int nodes)
        {
            adj_list = new List<int>[nodes];
            for (int i = 0; i < nodes; i ++)
            {
                adj_list[i] = new List<int>();
            }
        }

        public void AddEdge(int start, int end)
        {
            adj_list[start].Add(end);
            adj_list[end].Add(start);
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < adj_list.Length; i++)
            {
                result += i + " --> ";
                foreach (int node in adj_list[i])
                {
                    result += node + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
namespace IMS
{
    internal class Maze
    {
        private int nodes;
        List<int>[] graph;
        //Dictionary<int, List<int>> maze;
        public Maze(int nodes)
        {
            this.nodes = nodes;

            graph = new List<int>[nodes];
            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nodes; i++)
            {
                s += i + " --> " + String.Join(" ", graph[i]) + "\n";
            }
            return s;
        }
    }
}
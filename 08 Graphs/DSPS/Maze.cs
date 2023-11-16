namespace DSPS
{
    class Maze
    {
        int nodes;
        List<int>[] graph;

        public Maze(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes];   //create graph with nr of nodes
            for (int i = 0; i < nodes; i++) //init all lists
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
            //maze.AddEdge(0, 1);
            //to make it better, check if a node already is in the list, not going out of bounds
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
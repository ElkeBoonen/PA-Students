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



        public string DFS(int startnode, List<int> visited = null)
        {
            if (visited == null) visited = new List<int>();

            visited.Add(startnode);

            foreach (var node in graph[startnode])
            {
                if (!visited.Contains(node))
                {
                    DFS(node, visited);
                }
            }
            return String.Join(" ", visited);
        }

        /*
            Start with a node!
            Store the nodes you have already visited! 
            As long as there are (connected) nodes to visit:
            - check children of node
            - child already visited? do nothing
            - child not visited yet? visit! (recursive call or push to stack)
         */

        public string DFS_Stack(int startnode)
        {
            Stack<int> stack = new Stack<int>();
            List<int> visited = new List<int>();

            stack.Push(startnode);

            while (stack.Count > 0)
            {
                int node = stack.Pop();
                visited.Add(node);

                if (node == 0) return String.Join(" ", visited);

                foreach (var nextNode in graph[node])
                {
                    if (!visited.Contains(nextNode))
                    {
                        stack.Push(nextNode);
                    }
                }
            }
            return String.Join(" ", visited);
        }

        public string BFS(int startnode)
        {
            Queue<int> queue = new Queue<int>();
            List<int> visited = new List<int>();

            queue.Enqueue(startnode);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                if (!visited.Contains(node)) visited.Add(node);

                if (node == 0) return String.Join(" ", visited);

                foreach (var nextNode in graph[node])
                {
                    if (!visited.Contains(nextNode))
                    {
                        queue.Enqueue(nextNode);
                    }
                }
            }
            return String.Join(" ", visited);
        }
    }
}
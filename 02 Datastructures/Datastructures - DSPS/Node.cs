using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures___DSPS
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}

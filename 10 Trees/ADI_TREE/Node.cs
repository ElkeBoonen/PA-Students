using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADI_TREE
{
    internal class Node
    {
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value) 
        { 
            this.Key = value;
            this.Left = null;
            this.Right = null;
        }
    }
}

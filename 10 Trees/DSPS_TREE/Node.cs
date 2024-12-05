using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS_TREE
{
    internal class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }

        public Node(int value)
        { 
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }
}

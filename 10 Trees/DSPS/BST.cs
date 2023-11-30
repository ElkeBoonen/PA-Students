using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    public class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            Root = null;
        }

        public BST(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Add(Root, value);
            }
        }

        private void Add(Node node, int value)
        {
            //let's code
        }
    }
}

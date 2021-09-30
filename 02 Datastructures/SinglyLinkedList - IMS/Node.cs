using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList___IMS
{
    class Node
    {
        public double Data { get; set; }
        public Node Next { get; set; }

        public Node(double data)
        {
            Data = data;
            Next = null;
        }
    }
}

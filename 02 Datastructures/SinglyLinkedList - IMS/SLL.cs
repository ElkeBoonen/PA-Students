using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList___IMS
{
    class SLL
    {
        //singly linked list
        public Node Head { get; set; }
        private Node Last { get; set; }

        public SLL()
        {
            Head = null;
            Last = Head;
        }

        public void Insert(Node node)
        {
            //insert node achteraan!
            if (Head == null)
            {
                Head = node;
                Last = Head;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }

        public bool Delete(double data) 
        {
            Node node = Head;
            Node prev = null;

            if (node != null && node.Data == data)
            {
                Head = node.Next;
                return true;
            }
            while (node.Next != null && node.Data != data)
            {
                prev = node;
                node = node.Next;
            }
            if (node == null) return false;

            if (prev.Next == Last)
            {
                Last = prev;
                return true;
            }
            prev.Next = node.Next;
            return true;

        }

        public override string ToString()
        {
            string s = "";
            Node node = Head;
            if (node == null) return "lege lijst";
            do
            {
                s += node.Data + " ";
                node = node.Next;
            }
            while (node != null);
           
            return s;
        }


    }
}

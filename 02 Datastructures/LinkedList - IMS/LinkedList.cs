using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList___IMS
{
    class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void InsertFront(string data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public void InsertLast(string data)
        {
            Node node = new Node(data);
            if (Head == null) Head = node;
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }

        public override string ToString()
        {
            string s = "";
            Node temp = Head;
            while (temp.Next != null)
            {
                s += temp.Data + " -> ";
                temp = temp.Next;
            }

            return s + temp.Data; //om de laatste te krijgen
        }
    }
}

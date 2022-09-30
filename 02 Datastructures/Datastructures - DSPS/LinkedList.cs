using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures___DSPS
{
    class LinkedList
    {
        public Node Head { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        public void InsertFront(string data)
        {
            Node newnode = new Node(data);
            newnode.Next = Head;
            Head = newnode;
        }

        public void InsertLast(string data)
        {
            Node newnode = new Node(data);
            if (Head == null)
            {
                Head = newnode;
                return;
            }
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newnode;
        }

        public override string ToString()
         {
             string s = "";
             Node temp = Head;
             while (temp != null)
             {
                 s += temp.Data + " -> ";
                 temp = temp.Next;
             }
             return s.Substring(0,s.Length-4);
         }


    }
}

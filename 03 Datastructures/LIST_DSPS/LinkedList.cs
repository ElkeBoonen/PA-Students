using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST_DSPS
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(string data)
        {
            Head = new Node(data);
        }

        public void AddStart(string data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node node = new Node(data);
                node.Next = Head;
                Head = node;
            }
        }

        public void Delete(string data)
        {
            if (Head.Data == data)
            {
                Head = Head.Next;
            }
            else
            {
                Node node = Head;
                while (node != null && node != Last() )
                {
                    Console.WriteLine(node.Data);
                    if (node.Next.Data == data)
                    {
                        if (node.Next != Last()) node.Next = node.Next.Next;
                        else node.Next = null;
                    }
                    node = node.Next;
                }
            }
        }

        private Node Last()
        { 
            Node node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            return node;
        }

        public void AddEnd(string data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Last().Next = new Node(data);
            }
        }

        public override string ToString()
        {
            string linkedlist = "";
            Node node = Head;
            while (node != null)
            {
                linkedlist += node.Data + " -> ";
                node = node.Next;
            }
            return linkedlist;
        }
    }
}

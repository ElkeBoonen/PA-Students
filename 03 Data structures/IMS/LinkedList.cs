using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
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
    class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(Node node)
        {
            Head = node;
        }

        private Node Last()
        {
            Node iterator = Head;
            while (iterator.Next != null)
            { 
                iterator = iterator.Next;
            }
            return iterator; 
        }

        public void Insert(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Last().Next = node;
            }
        }

        public void Remove(string data)
        { }

        public bool Search(string data)
        { }

        public override string ToString()
        {
            string list = "HEAD: ";
            Node iterator = Head;
            while (iterator != null)
            {
                list += iterator.Data + " --> ";
                iterator = iterator.Next;
            }
            return list;
        }
    }
}

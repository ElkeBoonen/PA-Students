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
        {
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            Node previous = null;
            while (current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }
            
            if (current == null) return;

            previous.Next = current.Next;
        }

        public bool Search(string data)
        {
            Node iterator = Head;
            while (iterator != null)
            {
                if (iterator.Data == data) return true;
                iterator = iterator.Next;
            }
            return false;
        }

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

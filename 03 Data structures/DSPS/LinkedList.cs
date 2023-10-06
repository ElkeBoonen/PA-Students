using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
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
        public LinkedList(Node head)
        {
            Head = head;
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

        public bool Search(int data)
        {
            Node iterator = Head;
            while (iterator != null)
            {
                if (iterator.Data == data) return true;
                iterator = iterator.Next;
            }
            return false;
        }

        public void Delete(int data)
        {
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node iterator = Head;
            while (iterator.Next != null)
            {
                if (iterator.Next.Data == data)
                {
                    iterator.Next = iterator.Next.Next;
                    return;
                }
            }
        }

        public override string ToString()
        {
            if (Head == null) return "Empty list!";

            string list = "";
            Node iterator = Head;
            while (iterator.Next != null)
            {
                list += $"{iterator.Data} --> ";
                iterator = iterator.Next;
            }
            list += $"{iterator.Data} --> ";

            return list;
        }
    }
}

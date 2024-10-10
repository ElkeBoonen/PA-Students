using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LIST_ADI
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        //List<string> list = new List<string>();
        public LinkedList()
        {
            Head = null;
        }

        //List<string> list = new List<string> { "test" };
        public LinkedList(string data)
        { 
            Head = new Node(data);
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

        //achteraan toevoegen
        internal void Add(string data)
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

        //vooraan toevoegen
        internal void Insert(string data)
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

        internal void Delete(string data)
        {
            if (Head.Data == data)
            {
                Head = Head.Next;
            }
            else
            {
                Node iterator = Head;

                while (iterator.Next != null)
                {
                    if (iterator.Next.Data == data)
                    {
                        if (Last() == iterator.Next) iterator.Next = null;
                        else iterator.Next = iterator.Next.Next;
                    }
                    else iterator = iterator.Next;
                }
            }
        }

        public override string ToString()
        {
            string list = "";
            Node iterator = Head;

            while (iterator != null)
            {
                list += iterator.Data + " -> ";
                iterator = iterator.Next;
            }
            return list;
        }

       
    }
}

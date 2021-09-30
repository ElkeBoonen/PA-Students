using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List___DSPS
{
    class SLL
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public SLL()
        {
            Head = null;
            Tail = Head;
        }

        public void Insert(int data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else if (Head != null && Head == Tail)
            {
                Head.Next = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

        }

        public bool Delete(int data)
        {
            if (Head.Data == data)
            {
                Head = Head.Next;
                return true;
            }
            Node iterator = Head;
            Node previous = null;
            do
            {
                previous = iterator;
                iterator = iterator.Next;
            }
            while (iterator.Data != data);
            if (data == Tail.Data)
            {
                Tail = previous;
                Tail.Next = null;
                return true;
            }
            previous.Next = iterator.Next;
            return true;
        }

        public override string ToString()
        {
            if (Head == null) return "Empty list";
            string s = "";
            Node iterator = Head;
            do {
                s += iterator.Data + " ";
                if (iterator.Next != null) iterator = iterator.Next;
                else break;
            }
            while (iterator != null);
            return s;
        }
    }
}

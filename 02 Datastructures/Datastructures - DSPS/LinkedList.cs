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

        public bool Search(string data)
        {
            Node temp = Head;
            //bool found = false;
            while (temp != null)
            {
                if (temp.Data == data) return true; //found = true; break;
                temp = temp.Next;
            }
            return false; //return found;
        }

        public string Delete(string data)
        {
            if (Head != null)
            {
                if (Head.Data == data)
                {
                    Head = Head.Next;
                    return this.ToString();
                }
                else
                {
                    Node prev = Head;
                    Node temp = Head.Next;

                    while (temp != null)
                    {
                        if (temp.Data == data)
                        {
                            prev.Next = temp.Next;
                            return this.ToString();
                        }
                        prev = temp;
                        temp = temp.Next;
                    }
                    return this.ToString();
                }
            } 
            return "Empty linked list";
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

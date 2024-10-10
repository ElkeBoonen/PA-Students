using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST_DSPS
{
    internal class Stack
    {
        private LinkedList list;
        private int count;
        public int Size { get; set; }

        public Stack(int size)
        {
            list = new LinkedList();
            Size = size;
            count = 0;
        }
        //add element to the stack
        public void Push(string data)
        { 
            if (count == Size) throw new StackOverflowException();
            list.AddStart(data);
            count++;
        }
        //remove element
        public void Pop()
        {
            if (count == 0) throw new StackOverflowException();
            list.Delete(list.Head.Data);
            count--;
        }

        public override string ToString()
        {
            return list.ToString();
        }
    }
}

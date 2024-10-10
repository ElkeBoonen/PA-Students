using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST_ADI
{
    internal class Stack
    {
        public int Size { get; set; }
        private LinkedList list;
        private int count = 0;

        public Stack(int size)
        {
            this.Size = size;
            list = new LinkedList();
        }
        internal void Push(string data)
        {
            if (count < Size)
            {
                list.Insert(data);
                count++;
            }
            else throw new StackOverflowException();
        }
        internal void Pop()
        {
            if (count > 0)
            {
                list.Delete(list.Head.Data);
                count--;
            }
            else throw new StackOverflowException();
        }
        public override string ToString()
        {
            return list.ToString();
        }

       
    }
}

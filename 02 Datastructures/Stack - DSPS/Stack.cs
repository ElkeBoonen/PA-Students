using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___DSPS
{
    class Stack
    {
        private char[] elements { get; set; }
        private int top { get; set; }

        public Stack(int size = 5)
        {
            elements = new char[size];
            top = -1;
        }

        public void Push(char c)
        {
            if (top + 1 == elements.Length) Console.WriteLine("STACK OVERFLOW");
            else
            {
                top++;
                elements[top] = c;
            }
        }

        public void Pop()
        {
            if (top == -1) Console.WriteLine("STACK UNDERFLOW");
            else
            {
                top--;
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i <= top; i++)
            {
                s += elements[i] + " ";
            }
            return s;
        }
    }
}

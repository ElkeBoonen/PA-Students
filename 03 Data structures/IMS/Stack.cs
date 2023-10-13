using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Stack
    {
        private string[] stack;
        private int top;

        public Stack(int size)
        {
            stack = new string[size];
            top = 0;
        }

        public void Push(string data)
        {
            if (top == stack.Length) throw new Exception("Stack Overflow");

            stack[top] = data;
            top++;
        }

        public string Pop()
        {
            if (top == 0) throw new Exception("Stack Underflow");

            string temp = stack[top-1];
            stack[top-1] = "";
            top--;
            return temp;
        }

        public override string ToString()
        {
            return String.Join(" | ", stack);
        }


    }
}

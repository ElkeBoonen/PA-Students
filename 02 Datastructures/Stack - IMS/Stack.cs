using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack___IMS
{
    class Stack
    {
        double[] _elements; //can me anything
        int _top; //hold the top!

        public Stack(int size = 5)
        {
            _elements = new double[size];
            _top = -1;
        }

        public bool Push(double data) 
        {
            if (_top == _elements.Length - 1) return false;
            _top++;
            _elements[_top] = data;
            return true;
        
        }
        public bool Pop() 
        {
            if (_top < 0) return false; 
            _top--;
            return true;
        }

        public override string ToString() 
        {
            string s = "";
            for (int i = 0; i <= _top; i++)
            {
                s += _elements[i] + " ";
            }
            return s;
        }
    }
}

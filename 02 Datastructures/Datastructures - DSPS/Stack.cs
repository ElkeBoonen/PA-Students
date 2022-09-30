using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Datastructures___DSPS
{
    class Stack
    {
        private string[] _array;
        private int _top;

        public Stack(int size)
        {
            _array = new string[size];
            for (int i = 0; i < size; i++)
            {
                _array[i] = string.Empty;
            }
            _top = -1;
        }

        public string Push(string data)
        {
            if (_top >= _array.Length-1) return "OVERFLOW";
            _top++;
            _array[_top] = data;
            return this.ToString();
        }

        public string Pop()
        {
            if (_top < 0) return "UNDERFLOW";
            _array[_top] = String.Empty;
            _top--;
            return this.ToString();
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in _array)
            {
                if (item != String.Empty) s += item + " | ";
            }
            return s;
        }

    }
}

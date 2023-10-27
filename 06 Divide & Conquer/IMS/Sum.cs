using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class Sum
    {
        public int SolveIt(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public int Solve(int[] array, int index = 0)
        {
            if (array.Length == index) return 0;

            return array[index]+Solve(array,++index);
            //return array[index]+Solve(array,index + 1);
            //return array[index] + Solve(array, index++); //NOOIT GEBRUIKEN!! STACK OVERFLOW, post increment, eerst doorsturen dan optellen
        }

        public int Solve(List<int> list)
        { 
            if (list.Count == 0) return 0;

            int temp = list[0];
            list.RemoveAt(0);
            return temp + Solve(list);
        }
    }
}

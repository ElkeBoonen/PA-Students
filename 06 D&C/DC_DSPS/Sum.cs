using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DC_DSPS
{
    internal class Sum
    {
        public int Iterative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public int Recursive(int[] array, int index=0)
        {
            if (index == array.Length)
            {
                return 0;
            }
            return array[index] + Recursive(array, index+1);
        }

        public int Recursive(int[] array, int sum, int index)
        {
            if (index == array.Length)
            {
                return sum;
            }
            sum += array[index];
            return Recursive(array, sum, index + 1);
        }

        internal int DC(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }
            int temp = list[0];
            list.RemoveAt(0);
            return temp + DC(list);
        }
    }
}

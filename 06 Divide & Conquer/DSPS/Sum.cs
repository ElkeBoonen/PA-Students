using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Sum
    {
        public int Iterative(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public int DCList(List<int> list)
        {
            if (list.Count == 0) return 0;
            //if (list.Count == 1) return list[0];

            int value = list[0];
            list.RemoveAt(0);
            return value + DCList(list);
        }

        public int DCArray(int[] array, int index=0)
        {
            if (index == array.Length) return 0;

            return array[index] + DCArray(array, ++index);
            //return array[index] + DCArray(array, index + 1);  //OK
            //return array[index] + DCArray(array, index++);    //PROBLEM!! POST INCREMENTATION

        }
    }
}

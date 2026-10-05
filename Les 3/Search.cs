using System;
using System.IO;

namespace Recursie
{  
    class Search
    {
        public bool Binary(int[] array, int target)
        {
            return Binary(array, target, 0, array.Length);
        }

        public bool Binary(int[] array, int target, int left, int right)
        {
            if (left > right) return false;

            int mid = (left+right)/2;
            if (array[mid] == target) return true;
            else if (array[mid] < target)
            {
                return Binary(array, target, mid + 1, right);
            }
            else
            {
                return Binary(array, target, left, mid -1);
            }
        }
    }
}
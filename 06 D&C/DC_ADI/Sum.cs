

namespace DC_ADI
{
    internal class Sum
    {
        internal int Iterative(int[] array)
        {
            int sum = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        internal int Recursive(int[] array, int index = 0)
        {
            if (index == array.Length) return 0;
            return array[index] + Recursive(array, index + 1);
        }

        internal int Recursive(int[] array, int index, int sum)
        {
            if (index == array.Length) return sum;
            sum += array[index];
            return Recursive(array, index + 1, sum);
        }

        internal int DC(List<int> list)
        {
            //if (list.Count == 0) return 0;

            if (list.Count == 1) return list[0];

            int item = list.First(); //list[0]
            list.RemoveAt(0);
            return item + DC(list);
        }
    }
}
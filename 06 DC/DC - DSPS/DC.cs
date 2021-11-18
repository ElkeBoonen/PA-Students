using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DC___DSPS
{
    class DC
    {
        public int Squares(int A, int B)
        {
            if (A == 0) return B;
            if (B == 0) return A;

            int rest;
            if (A > B) {
                rest = A % B;
                return Squares(B, rest);
            } 
            rest = B % A;
            return Squares(A, rest);
        }

        public int SquaresIterative(int A, int B)
        {
            int remainder = A % B;
            while (remainder != 0)
            {
                A = B;
                B = remainder;
                remainder = A % B;
            }
            return B; 
        }

        public int SumIterative(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public int Sum(int index, int[] array)
        {
            if (index == array.Length) return 0;

            //return array[index] + Sum(index + 1, array);
            //never use index++ --> stackoverflow
            return array[index] + Sum(++index, array);
        }

        public int Sum(List<int> list)
        {
            if (list.Count == 0) return 0;

            int first = list[0];
            list.RemoveAt(0);

            return first + Sum(list);
        }

        public int SumOne(List<int> list)
        {
            if (list.Count == 1) return list[0];

            int first = list[0];
            list.RemoveAt(0);

            return first + Sum(list);
        }

        public int SumTwo(List<int> list)
        {
            //this will fail if we call method with only 1 element!!!
            if (list.Count == 2) return list[0]+list[1];

            int first = list[0];
            list.RemoveAt(0);

            return first + Sum(list);
        }

        public List<int> QuickSort(List<int> list)
        {
            if (list.Count < 1) return list;
            int pivot = list[0];
            list.RemoveAt(0);

            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();
            List<int> pivotlist = new List<int>();
            pivotlist.Add(pivot);

            foreach (var item in list)
            {
                if (item < pivot) smaller.Add(item);
                if (item > pivot) bigger.Add(item);
            }
            return QuickSort(smaller).Union(pivotlist).Union(QuickSort(bigger)).ToList();
        }

        /*public int[] Quicksort(int[] array, int lo, int hi)
        {
            if (lo < hi)
            {
            p:= partition(A, lo, hi)
        quicksort(A, lo, p)
        quicksort(A, p + 1, hi)
            }
        }

        algorithm partition(A, lo, hi) is
            pivot := A[⌊(hi + lo) / 2⌋]
            i := lo - 1
            j := hi + 1
            loop forever
                do
                    i := i + 1
                while A[i] < pivot
                do
                    j := j - 1
                while A[j] > pivot
                if i ≥ j then
                    return j
                swap A[i] with A[j]
        */

       public void Hanoi(int number, char from, char to, char other)
        {
            if (number == 1) Console.WriteLine("disk 1 from {0} to {1}", from, to);
            if (number > 1)
            {
                Hanoi(number - 1, from, other, to);
                Console.WriteLine("disk {0} from {1} to {2}", number, from, to);
                Hanoi(number - 1, other, to, from);
            }
        }
       

      
    }
}

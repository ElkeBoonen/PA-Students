using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC___IMS
{
    class DC
    {
        public int Squares(int A, int B)
        {
            if (A == 0) return B;
            if (B == 0) return A;

            int min = Math.Min(A, B);
            int max = Math.Max(A, B);
            int rest = max - min;
            return Squares(rest, min);
        }

        public int SquaresSlides(int A, int B)
        {
            if (A == 0) return B;
            if (B == 0) return A;

            int remainder = A % B;
            return SquaresSlides(B, remainder);
        }

        public int SquaresIterative(int A, int B)
        {
            int min = Math.Min(A, B);
            int max = Math.Max(A, B);
            int rest = 0;
            while (max % min != 0)
            {
                rest = max % min;
                max = min;
                min = rest;
            }
            return min;
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
            return array[index] + Sum(index + 1, array);
        }

        public int SumSlides(List<int> list)
        {
            if (list.Count == 0) return 0;
            int first = list[0];
            list.RemoveAt(0);
            return first + SumSlides(list);
        }

        public int SumAron(int[] array, int index = 0)
        {
            int sum = 0;
            if (array.Length > index)
            {
                sum += array[index] + SumAron(array, ++index);
                //SumAron(array, ++index); als je dat hier laat staan, doe je niets met som!
            }
            return sum;
        }

        public List<int> QuickSort(List<int> list)
        {
            if (list.Count < 2) return list; // base case

            int pivot = list.First();
            list.RemoveAt(0);
            List<int> less = new List<int>();
            List<int> more = new List<int>();

            foreach (var item in list)
            {
                if (item < pivot) less.Add(item);
                else more.Add(item);
            }

            return QuickSort(less).Union(new List<int> { pivot }).Union(QuickSort(more)).ToList();
        }

        /*algorithm quicksort(A, lo, hi) is
        if lo<hi then
            p := partition(A, lo, hi)
            quicksort(A, lo, p)
            quicksort(A, p + 1, hi)

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

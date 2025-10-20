using System;
using System.ComponentModel.DataAnnotations;

namespace PAStudents
{
    //https://javalab.org/en/hanoi_tower_en/
    class Hanoi
    {

        /*
            A --> B
            A --> C
            B --> C
        */
        public void Solve(int disks, char from, char to, char other)
        {
            if (disks == 1) Console.WriteLine($"Move {disks} from {from} to {to}");
            else
            {
                Solve(disks - 1, from, other, to);
                Console.WriteLine($"Move {disks} from {from} to {to}");
                Solve(disks - 1, other, to, from);
            }

        }

    }

    class QuickSort
    {

        public int Count { get; set; }
        public List<int> Sort(List<int> list)
        {
            Count++;
            if (list.Count <= 1) return list;

            List<int> small = new List<int>();
            List<int> big = new List<int>();
            List<int> same = new List<int>();

            int pivot = list[0];

            foreach (int element in list)
            {
                Count++;
                if (pivot > element) small.Add(element);
                else if (pivot < element) big.Add(element);
                else same.Add(pivot);
            }

            return Sort(small).Concat(same).Concat(Sort(big)).ToList<int>();
            //return Solve(small).Union(new List<int>() { pivot }).Union(Solve(big)).ToList<int>();
            //Union verwijdert duplicaten

        }

    }

    class Exercises
    {
        //Array Multiplication - Split array, multiply each half, multiply results

        public int Multiplication(List<int> list)
        {
            if (list.Count == 1) return list[0];
            else if (list.Count == 0) return 1;

            int middle = list.Count / 2;
            List<int> left = list.GetRange(0, middle);
            Console.WriteLine(String.Join(" ", left));
            List<int> right = list.GetRange(middle, list.Count - middle);
            Console.WriteLine(String.Join(" ", right));

            int product = Multiplication(left) * Multiplication(right);
            return product;
        }

        public int MultiplicationF(List<int> list)
        {
            int product = 1;
            foreach (int element in list)
            {
                product *= element;
            }
            return product;
        }
        
        public int MultiplicationR(List<int> list, int index=0)
        {
            if (index == list.Count) return 1;
            return list[index] * MultiplicationR(list, index+1);
        }
    }

}
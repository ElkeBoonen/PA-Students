using System;

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
}

namespace DC_DSPS
{
    internal class QuickSort
    {
        internal List<int> Sort(List<int> list)
        {
            if (list.Count <= 1) return list;

            int pivot = list[0]; // list.First() 

            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            foreach (int item in list)
            {
                if (item < pivot) less.Add(item);
                else if (item > pivot) greater.Add(item);
            }
            return Sort(less).Union(new List<int> { pivot }).Union(Sort(greater)).ToList();
        }

        internal List<int> Sort2(List<int> list)
        {
            if (list.Count <= 1) return list;

            int pivot = list[0]; // list.First() 

            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            List<int> same = new List<int>();

            foreach (int item in list)
            {
                if (item < pivot) less.Add(item);
                else if (item > pivot) greater.Add(item);
                else same.Add(item);
            }

            return Sort2(less).Concat(same).Concat(Sort2(greater)).ToList();
        }


    }
}
namespace PAStudents
{
    class Subset
    {
        int[] array;

        public Subset(int[] a)
        {
            array = a;
        }

        public void Solve(List<int> subset,int index=0)
        {
            //Console.WriteLine("In Solve --> " + String.Join(" ", subset));
            if (index == array.Length)
            {
                Console.WriteLine(String.Join(" ", subset));
                return;
            }

            subset.Add(array[index]);
            Solve(subset, index + 1);
            subset.Remove(array[index]);
            Solve(subset, index + 1);

        }
    }

}
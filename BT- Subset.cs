namespace PAStudents
{
    class Subset
    {
        int[] array;

        public Subset(int[] a)
        {
            array = a;
        }

        public void Solve(List<int> subset, int index = 0)
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
        
        public void Solve2()
        {
            int count = (int)Math.Pow(2, array.Length);

            for (int i = 0; i < count; i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1') Console.Write(array[j]+" ");
                }
                Console.WriteLine();
            }

        }
    }

}
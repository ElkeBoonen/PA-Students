namespace BACK_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queens queens = new Queens(8); // 4 = nr queens
            queens.Solve(0);    //0 = meest linkse kolom
            Console.WriteLine(queens);

            Subset subset = new Subset();
            List<List<int>> subsets = subset.Solve(new int[] { 1, 2, 3 });
            foreach (List<int> set in subsets)
            {
                Console.WriteLine(String.Join(" ", set));
            }


        }
    }
}

namespace Hello_Big_O___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();

            int[] array = TM.ProgrammingAdvanced.Data.Numbers;

            Console.Write("Give a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count;

            int pos = search.Simple(array, number, out count);
            Console.WriteLine($"SIMPLE - {number} is on position {pos} --> count {count}");

            pos = search.Stupid(array, number, out count);
            Console.WriteLine($"STUPID - {number} is on position {pos} --> count {count}");

            pos = search.Smart(array, number, out count);
            Console.WriteLine($"SMART - {number} is on position {pos} --> count {count}");

            pos = search.SmartPaul(array, number, out count);
            Console.WriteLine($"SMART PAUL - {number} is on position {pos} --> count {count}");


        }
    }
}
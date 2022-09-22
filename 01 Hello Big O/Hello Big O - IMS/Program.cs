using System.Transactions;

namespace Hello_Big_O___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search(TM.ProgrammingAdvanced.Data.Numbers);

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count;

            Console.WriteLine($"SIMPLE {number} -> position: {search.Simple(number, out count)} in {count} steps");
            Console.WriteLine($"STUPID {number} -> position: {search.Stupid(number, out count)} in {count} steps");
            Console.WriteLine($"SMART {number} -> position: {search.Smart(number, out count)} in {count} steps");


        }
    }
}
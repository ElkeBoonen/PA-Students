using System.Net;

namespace SORT_IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Sort sort = new Sort();

            //int[] array = { 2, 8, 3, 7, 11, 17, 9, 4 };
            int[] array = Array.ConvertAll(File.ReadAllLines("numbers.txt"),Convert.ToInt32);

            Console.WriteLine(String.Join(" ", array));
            sort.Bubble(array);
            //Console.WriteLine(String.Join(" ", array));
            Console.WriteLine("COUNT = " + sort.Count);

            array = Array.ConvertAll(File.ReadAllLines("numbers.txt"), Convert.ToInt32);
            //Console.WriteLine(String.Join(" ", array));
            sort.Selection(array);
            //Console.WriteLine(String.Join(" ", array));
            Console.WriteLine("COUNT = " + sort.Count);


            array = Array.ConvertAll(File.ReadAllLines("numbers.txt"), Convert.ToInt32);
            //Console.WriteLine(String.Join(" ", array));
            sort.Insertion(array);
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine("COUNT = " + sort.Count);



            string[] fruit = { "banaan", "bes", "kiwi", "appel", "mango", "druif", "ananas" };
            Console.WriteLine(String.Join(" ", fruit));
            sort.Bubble(fruit);
            Console.WriteLine(String.Join(" ", fruit));


        }
    }
}

using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList("appel");
            list.Insert("banaan");
            list.Insert("peer");
            list.Insert("druif");
            list.Insert("kiwi");
            Console.WriteLine(list);

            Console.WriteLine("Delete mango: " + list.Delete("mango"));
            Console.WriteLine(list);
            Console.WriteLine("Delete appel: " + list.Delete("appel"));
            Console.WriteLine(list);
            Console.WriteLine("Delete kiwi: " + list.Delete("kiwi"));
            Console.WriteLine(list);
            Console.WriteLine("Delete peer: " + list.Delete("peer"));
            Console.WriteLine(list);
            list.Insert("appel");
            Console.WriteLine(list);
            Console.WriteLine("Delete banaan: " + list.Delete("banaan"));
            Console.WriteLine(list);
            Console.WriteLine("Delete druif: " + list.Delete("druif"));
            Console.WriteLine(list);

            list.Insert("appel");
            Console.WriteLine(list);

            Console.WriteLine("Search mango: " + list.Search("mango"));
            Console.WriteLine("Search appel: " + list.Search("appel"));

            Stack stack = new Stack(5);
            stack.Push("appel"); Console.WriteLine(stack);
            stack.Push("appel"); Console.WriteLine(stack);
            stack.Push("appel"); Console.WriteLine(stack);
            stack.Push("appel"); Console.WriteLine(stack);
            stack.Push("appel"); Console.WriteLine(stack);
            stack.Pop(); Console.WriteLine(stack);
            stack.Pop(); Console.WriteLine(stack);
            stack.Pop(); Console.WriteLine(stack);
            stack.Pop(); Console.WriteLine(stack);
            stack.Pop(); Console.WriteLine(stack);
            stack.Pop(); Console.WriteLine(stack);
        

            /*Sorting sorting = new Sorting();
            int[] array = Array.ConvertAll(File.ReadAllLines(@"Files/sorted_numbers.txt"), Convert.ToInt32);
            //Console.WriteLine(String.Join(" ", array));
            sorting.Bubble(array);
            Console.WriteLine("Bubble --> " + sorting.Count);

            array = Array.ConvertAll(File.ReadAllLines(@"Files/sorted_numbers.txt"), Convert.ToInt32);
            sorting.Selection(array);
            Console.WriteLine("Selection --> " + sorting.Count);

            array = Array.ConvertAll(File.ReadAllLines(@"Files/sorted_numbers.txt"), Convert.ToInt32);
            sorting.Insertion(array);
            Console.WriteLine("Insertion --> " + sorting.Count);
            */
        }
    }
}
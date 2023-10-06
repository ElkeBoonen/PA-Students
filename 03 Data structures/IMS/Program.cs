namespace IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine(list);

            list.Insert(new Node("appel"));
            list.Insert(new Node("druif"));
            list.Insert(new Node("banaan"));
            Console.WriteLine(list);

            list.Insert(new Node("peer"));
            Console.WriteLine(list);

        }
    }
}
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

            Console.WriteLine($"appel: {list.Search("appel")}");
            Console.WriteLine($"peer: {list.Search("peer")}");
            Console.WriteLine($"kiwi: {list.Search("kiwi")}");

            list.Remove("appel");
            Console.WriteLine(list);
            list.Remove("peer");
            Console.WriteLine(list);
            list.Remove("druif");
            Console.WriteLine(list);

            list.Remove("banaan");
            Console.WriteLine(list);

            try {
                Stack snoep = new Stack(3);

                Console.WriteLine(snoep);
                snoep.Push("m&m's");
                snoep.Push("chocotoff");
                snoep.Push("schepsnoep");
                Console.WriteLine(snoep);

                //snoep.Push("popcorn"); --> geeft stack overflow

                Console.WriteLine(snoep.Pop());
                Console.WriteLine(snoep);
                Console.WriteLine(snoep.Pop());
                Console.WriteLine(snoep);
                Console.WriteLine(snoep.Pop());
                Console.WriteLine(snoep);
                
                //Console.WriteLine(snoep.Pop()); --> geeft underflow

                snoep.Push("schepsnoep");
                Console.WriteLine(snoep);

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
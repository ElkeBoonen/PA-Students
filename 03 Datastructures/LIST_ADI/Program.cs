using System.Linq.Expressions;

namespace LIST_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList fruit = new LinkedList(); Console.WriteLine("FRUIT: " + fruit);
            fruit.Add("appel"); Console.WriteLine("FRUIT: " + fruit);
            fruit.Add("banaan"); Console.WriteLine("FRUIT: " + fruit);
            fruit.Add("kiwi"); Console.WriteLine("FRUIT: " + fruit);
            fruit.Delete("appel"); Console.WriteLine("FRUIT: " + fruit);
            fruit.Delete("kiwi"); Console.WriteLine("FRUIT: " + fruit);
            fruit.Delete("banaan"); Console.WriteLine("FRUIT: " + fruit);

            LinkedList dieren = new LinkedList("olifant"); Console.WriteLine("DIEREN: "+dieren);
            dieren.Insert("giraf"); Console.WriteLine("DIEREN: " + dieren);
            dieren.Insert("kat"); Console.WriteLine("DIEREN: " + dieren);
            dieren.Insert("hond"); Console.WriteLine("DIEREN: " + dieren);
            dieren.Delete("kat"); Console.WriteLine("DIEREN: " + dieren);
            dieren.Delete("ezel"); Console.WriteLine("DIEREN: " + dieren);

            try {
                Stack kleuren = new Stack(5);
                kleuren.Push("groen"); Console.WriteLine(kleuren);
                kleuren.Push("roze"); Console.WriteLine(kleuren);
                kleuren.Push("blauw"); Console.WriteLine(kleuren);
                kleuren.Push("appelblauwzeegroen"); Console.WriteLine(kleuren);
                kleuren.Push("baksteenrood"); Console.WriteLine(kleuren);
                //kleuren.Push("cementgrijs"); Console.WriteLine(kleuren);

                kleuren.Pop(); Console.WriteLine(kleuren);
                kleuren.Pop(); Console.WriteLine(kleuren);
                kleuren.Pop(); Console.WriteLine(kleuren);
                kleuren.Pop(); Console.WriteLine(kleuren);
                kleuren.Pop(); Console.WriteLine(kleuren);
                //kleuren.Pop(); Console.WriteLine(kleuren);
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }

        }
    }
}

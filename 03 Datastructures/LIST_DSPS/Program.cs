namespace LIST_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList animals = new LinkedList();
            animals.AddEnd("elephant");
            animals.AddEnd("cat");
            animals.AddEnd("dog");
            animals.AddStart("turtle");

            Console.WriteLine("animals: " + animals);
            animals.Delete("cat");
            Console.WriteLine("animals: " + animals);
            animals.Delete("dog");
            Console.WriteLine("animals: " + animals);



            LinkedList fruit = new LinkedList("apple");
            Console.WriteLine("fruit: " + fruit);
            fruit.Delete("apple");
            Console.WriteLine("fruit: " + fruit);

            fruit.AddStart("kiwi");
            fruit.AddStart("pineapple");
            fruit.AddEnd("mango");
            Console.WriteLine("fruit: " + fruit);

            fruit.Delete("pineapple");
            Console.WriteLine("fruit: " + fruit);

            try {
                Stack stack = new Stack(5);

                stack.Push("1"); Console.WriteLine(stack);
                stack.Push("2"); Console.WriteLine(stack);
                stack.Push("3"); Console.WriteLine(stack);
                stack.Push("4"); Console.WriteLine(stack);
                stack.Push("5"); Console.WriteLine(stack);
                //stack.Push("6"); Console.WriteLine(stack);

                stack.Pop(); Console.WriteLine(stack);
                stack.Pop(); Console.WriteLine(stack);
                stack.Pop(); Console.WriteLine(stack);
                stack.Pop(); Console.WriteLine(stack);
                stack.Pop(); Console.WriteLine(stack);
                stack.Pop(); Console.WriteLine(stack);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());    
            }

        }
    }
}

using System.ComponentModel.Design;

namespace ADI_Gredy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.Lessons.Add(new Lesson("music", 11, 12));
            schedule.Lessons.Add(new Lesson("art", 9, 10));
            schedule.Lessons.Add(new Lesson("math", 10, 11));
            schedule.Lessons.Add(new Lesson("eng", 9.5, 10.5));
            schedule.Lessons.Add(new Lesson("cs", 10.5, 11.5));

            Console.WriteLine(schedule.ToString());
            schedule.Lessons.Sort();
            Console.WriteLine(schedule.ToString());

            List<Lesson> list = schedule.Make();
            foreach (Lesson l in list)
            {
                Console.WriteLine(l.Name);
            }


            Tree tree = new Tree(40);
            tree.Root.Left = new Node(25);
            tree.Root.Right = new Node(29);
            tree.Root.Left.Left = new Node(35);
            tree.Root.Left.Right = new Node(40);
            tree.Root.Right.Right = new Node(12);

            Console.WriteLine(tree.Greedy(tree.Root));
            Console.WriteLine(tree.Greedy());
            Console.WriteLine(tree.Other(tree.Root));



            Console.Read();
        }
    }
}

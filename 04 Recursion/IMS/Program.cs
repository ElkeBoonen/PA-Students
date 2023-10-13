using TM.ProgrammingAdvanced;

namespace IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check PS       >> cd "C:\rw0azbjcmf3"
            //voor treeview: >> tree /f

            string folder = @"C:\rw0azbjcmf3"; //Data.Folders(@"C:\");
            Console.WriteLine(folder);

            FindKey key = new FindKey();
            key.Count = 0;
            Console.WriteLine("Key --> " + key.Algorithm1(folder) + " Count " + key.Count);
            key.Count = 0;
            Console.WriteLine("Key --> " + key.Algorithm2(folder) + " Count " + key.Count);
        }
    }
}
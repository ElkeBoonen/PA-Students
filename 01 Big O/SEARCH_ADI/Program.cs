namespace SEARCH_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sorted_numbers.txt");
            int[] array = Array.ConvertAll(lines, Convert.ToInt32);

            Search search = new Search();

            int guess = 779;
            Console.WriteLine($"Stupid - position {guess} = {search.Stupid(array, guess)} --> {search.Count}");
            Console.WriteLine($"Linear - position {guess} = {search.Linear(array, guess)} --> {search.Count}");
            Console.WriteLine($"Binary - position {guess} = {search.Binary(array, guess)} --> {search.Count}");

            guess = 501;
            Console.WriteLine($"Stupid - position {guess} = {search.Stupid(array, guess)} --> {search.Count}");
            Console.WriteLine($"Linear - position {guess} = {search.Linear(array, guess)} --> {search.Count}");
            Console.WriteLine($"Binary - position {guess} = {search.Binary(array, guess)} --> {search.Count}");

            guess = -1000;
            Console.WriteLine($"Stupid - position {guess} = {search.Stupid(array, guess)} --> {search.Count}");
            Console.WriteLine($"Linear - position {guess} = {search.Linear(array, guess)} --> {search.Count}");
            Console.WriteLine($"Binary - position {guess} = {search.Binary(array, guess)} --> {search.Count}");

            guess = 998;
            Console.WriteLine($"Stupid - position {guess} = {search.Stupid(array, guess)} --> {search.Count}");
            Console.WriteLine($"Linear - position {guess} = {search.Linear(array, guess)} --> {search.Count}");
            Console.WriteLine($"Binary - position {guess} = {search.Binary(array, guess)} --> {search.Count}");

        }
    }
}

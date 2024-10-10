namespace SEARCH_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("sorted_numbers.txt");
            int[] array = Array.ConvertAll(lines, Convert.ToInt32);

            Search search = new Search();

            int guess = 861;
            Console.WriteLine($"Position {guess}: {search.Stupid(array, guess)} -> stupid -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Linear(array, guess)} -> linear -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Binary(array, guess)} -> binary -> needs {search.Count} guesses");

            guess = -998;
            Console.WriteLine($"Position {guess}: {search.Stupid(array, guess)} -> stupid -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Linear(array, guess)} -> linear -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Binary(array, guess)} -> binary -> needs {search.Count} guesses");

            guess = -1000;
            Console.WriteLine($"Position {guess}: {search.Stupid(array, guess)} -> stupid -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Linear(array, guess)} -> linear -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Binary(array, guess)} -> binary -> needs {search.Count} guesses");

            guess = 998;
            Console.WriteLine($"Position {guess}: {search.Stupid(array, guess)} -> stupid -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Linear(array, guess)} -> linear -> needs {search.Count} guesses");
            Console.WriteLine($"Position {guess}: {search.Binary(array, guess)} -> binary -> needs {search.Count} guesses");

        }
    }
}

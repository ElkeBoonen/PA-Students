namespace PAStudents
{
    public class Sorting
    {
        //https://visualgo.net/en/sorting
        //https://www.youtube.com/@AlgoRythmics
        public string Bubble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    //Console.WriteLine(String.Join(" ", array));
                }

            }
            return String.Join(" ", array);
        }

        public string Selection(int[] array)
        {
            //5 3 2 -1 10
            int smallest_index;
            for (int i = 0; i < array.Length; i++)
            {
                smallest_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest_index])
                    {
                        smallest_index = j;
                    }
                }

                int temp = array[smallest_index];
                array[smallest_index] = array[i];
                array[i] = temp;

                Console.WriteLine(String.Join(" ", array));
            }
            return String.Join(" ", array);
        }

        public string SelectionArray(int[] array)
        {
            //5 3 2 -1 10
            List<int> list = array.ToList<int>();
            List<int> list_new = new List<int>();

            //denk hier eens over na ;)
            while (list.Count > 0)
            {
                int smallest = list[0];
                foreach (int element in list)
                {
                    if (element < smallest)
                    {
                        smallest = element;
                    }
                }
                list_new.Add(smallest);
                list.Remove(smallest);
                Console.WriteLine(String.Join(" ", list_new) + " -- " + String.Join(" ", list));
            }

            return String.Join(" ", list_new);
        }

        public string Insertion(int[] array)
        { 
            
        }

    }

}
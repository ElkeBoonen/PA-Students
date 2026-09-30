namespace Les1
{

    class Search
    {
        public int Teller {get; private set;}

        public int Linear(int[] array, int target)
        {
            Teller = 0;
            foreach(int element in array)
            {
                Teller++;
                if (element == target) 
                {
                    return 1;
                }
            }
            return -1;
        }

        public int Binary(int[] array, int target)
        {
            int left = 0;
            int right = array.Length;

            Teller = 0;

            while (left <= right)
            {
                Teller++;
                int mid = (left+right)/2; //dit is een comment
                if (array[mid]==target)
                {
                    return 1;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid -1;
                }
            }
            return -1;
        }
    }

}

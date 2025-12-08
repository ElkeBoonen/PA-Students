namespace PAStudents
{
    class HashMap
    {
        private List<KeyValuePair<string,double>>[] map;

        private int NextPrime(int nr)
        {
            bool isPrime = false;
            while (!isPrime)
            {
                nr++;
                isPrime = true;
                for (int i = 2; i <= nr/2; i++)
                {
                    if (nr % i == 0) isPrime = false;
                }
            }
            return nr;
           
        }
        public HashMap(int items)
        {
            int length = NextPrime((int)(items*1.3));
            map = new List<KeyValuePair<string, double>>[length];  
            //Console.WriteLine(map.Length);
        }

        //https://www.dotnetperls.com/keyvaluepair
        public void AddItem(string key, double value)
        {
            int index = HashFunction(key);
            if (map[index]==null)
            {
                map[index] = new List<KeyValuePair<string, double>>();
            }
            map[index].Add(new KeyValuePair<string,double>(key, value));
        }

        public double GetPrice(string key)
        {
            int index = HashFunction(key);
            foreach (var item in map[index])
            {
                if (item.Key == key) return item.Value;
            }
            return -1;

        }

        private int HashFunction(string item)
        {
            /*int h = 0;
            foreach(char c in item) h += (int)c;
            return h % map.Length;
            */
            
            long h = 0;
            foreach (char c in item) h = (31 * h) + (int)c;
            return (int)(h % map.Length);

        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i]!=null)
                {
                    foreach (var item in map[i])
                    {
                        result += item.Key + ":" + item.Value + " ";
                    }
                }
                else result += "null";
                result+="\n";
                
            }

            return result;
        }
    }
}
